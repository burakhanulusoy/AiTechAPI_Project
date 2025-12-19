using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace AiTech.WebUI.Controllers
{
    public class AiController(IConfiguration _configuration,IHttpClientFactory _httpClientFactory) : Controller
    {
        private string _apiKey = _configuration["MyCloudeApiKey:Key"];

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AskClaude([FromBody] JsonElement data)
        {
            try
            {
                // JSON'dan prompt değerini güvenli bir şekilde alalım
                string prompt = data.GetProperty("prompt").GetString();

                if (string.IsNullOrEmpty(prompt)) return BadRequest("Soru boş olamaz.");
                if (string.IsNullOrEmpty(_apiKey)) return StatusCode(500, "API Anahtarı bulunamadı! Appsettings.json kontrol edilmeli.");

                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri("https://api.anthropic.com");
                client.DefaultRequestHeaders.Add("x-api-key", _apiKey);
                client.DefaultRequestHeaders.Add("anthropic-version", "2023-06-01");

                var requestBody = new
                {
                    model = "claude-sonnet-4-20250514", // ✅ Güncel model
                    max_tokens = 1024,
                    messages = new[] { new { role = "user", content = prompt } }
                };

                var jsonContent = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("v1/messages", jsonContent);
                var responseString = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    // API'den hata dönerse (400, 401, 403 vb.)
                    return BadRequest($"Claude API Hatası: {responseString}");
                }

                using var doc = JsonDocument.Parse(responseString);
                var text = doc.RootElement.GetProperty("content")[0].GetProperty("text").GetString();

                return Json(new { answer = text });
            }
            catch (Exception ex)
            {
                // Gerçek hatayı görmek için burayı döndürüyoruz
                return StatusCode(500, $"Sunucu Hatası: {ex.Message}");
            }
        }

    }
}
