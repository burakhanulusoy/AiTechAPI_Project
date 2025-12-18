using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace AiTech.WebUI.Controllers
{
    public class ContactController(IConfiguration configuration) : Controller
    {
        // OpenAI Key kontrolü
        private string MyApiKey => configuration["MyOpenAiKey:MyApiKey"]
                                   ?? throw new InvalidOperationException("API Key bulunamadı!");

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Talk(IFormFile audioFile)
        {
            if (audioFile == null || audioFile.Length == 0)
                return BadRequest("Ses dosyası yok.");

            var filePath = Path.GetTempFileName();

            try
            {
                // 1. Dosyayı geçici kaydet
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await audioFile.CopyToAsync(stream);
                }

                // 2. Whisper ile Sesi Yazıya Çevir
                string transcription = await TranscribeAudioAsync(filePath);

                // 3. ChatGPT'ye Cevap Ürettir
                string gptReply = await AskChatGptAsync(transcription);

                // 4. (YENİ) Cevabı OpenAI İnsan Sesiyle MP3'e Çevir
                byte[] audioBytes = await TextToSpeechAsync(gptReply);
                string audioBase64 = Convert.ToBase64String(audioBytes);

                // Frontend'e hem metni hem de ses dosyasının kodunu dönüyoruz
                return Json(new
                {
                    success = true,
                    userText = transcription,
                    botReply = gptReply,
                    audioData = audioBase64 // MP3 verisi burada
                });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
            finally
            {
                if (System.IO.File.Exists(filePath)) System.IO.File.Delete(filePath);
            }
        }

        // --- YENİ EKLENEN METOT: Text to Speech (Yazıyı Sese Çevir) ---
        private async Task<byte[]> TextToSpeechAsync(string textToRead)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MyApiKey);

            var payload = new
            {
                model = "tts-1",      // Model: tts-1 (hızlı) veya tts-1-hd (yüksek kalite)
                input = textToRead,
                voice = "alloy"       // Ses Seçenekleri: alloy, echo, fable, onyx, nova, shimmer
            };

            var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");

            // OpenAI ses API'sine istek atıyoruz
            var response = await client.PostAsync("https://api.openai.com/v1/audio/speech", content);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new Exception($"TTS Hatası: {errorContent}");
            }

            // Gelen MP3 dosyasını byte array olarak alıyoruz
            return await response.Content.ReadAsByteArrayAsync();
        }

        // --- ESKİ HELPERLAR (Aynı Kaldı) ---
        private async Task<string> TranscribeAudioAsync(string audioFilePath)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MyApiKey);
            using var form = new MultipartFormDataContent();

            var fileBytes = await System.IO.File.ReadAllBytesAsync(audioFilePath);
            var fileContent = new ByteArrayContent(fileBytes);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/webm");

            form.Add(fileContent, "file", "recording.webm");
            form.Add(new StringContent("whisper-1"), "model");

            var response = await client.PostAsync("https://api.openai.com/v1/audio/transcriptions", form);
            var result = await response.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(result);
            return doc.RootElement.GetProperty("text").GetString();
        }

        private async Task<string> AskChatGptAsync(string userMessage)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", MyApiKey);

            var payload = new
            {
                model = "gpt-4o-mini",
                messages = new[] { new { role = "user", content = userMessage } }
            };

            var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);
            var result = await response.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(result);
            return doc.RootElement.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();
        }
    }
}