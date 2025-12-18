
using AiTech.WebUI.DTOs.GeminiDtos;
using Newtonsoft.Json;
using System.Text;

namespace AiTech.WebUI.Services.GemineServices
{
    public class GeminiService : IGeminiService
    {
        private readonly HttpClient _client;
        private readonly string _apikey;
        private const string Model = "gemini-2.5-flash";
        private const string BaseUrl = "https://generativelanguage.googleapis.com/v1beta/models/";
      

        public GeminiService(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _apikey = configuration["MyOpenAiKey:MyApikey"];
        }

        public async Task<string> GenerateGeminiAsync(string prompt)
        {

            var requestBosy = new GeminiRequestDto
            {
                contents = new List<Content>
                {
                    new Content
                    {
                        role="user",
                        parts=new List<Part>
                        {
                            new Part
                            {
                                text=prompt
                            }
                        }
                    }

                },
                generationConfig = new GenerationConfig
                {
                    temperature = 0.7f,
                    maxOutputTokens = 10000
                }

            };
          
            var jsonContent=JsonConvert.SerializeObject(requestBosy);
            var httpContent=new StringContent(jsonContent,Encoding.UTF8,"application/json");
            var url = $"{BaseUrl}{Model}:generateContent?key={_apikey}";

            var response=await _client.PostAsync(url, httpContent);

            if(!response.IsSuccessStatusCode)
            {
                var message=await response.Content.ReadAsStringAsync();
                return message;
            }
            
            var responseString=await response.Content.ReadAsStringAsync();
            var geminiResponse=JsonConvert.DeserializeObject<GeminiResponseDto>(responseString);

            var resultText = geminiResponse.candidates.FirstOrDefault().content.parts.FirstOrDefault().text;

            return resultText ?? "Yanıt Alınamadı";
      
        
        }




    }
}



