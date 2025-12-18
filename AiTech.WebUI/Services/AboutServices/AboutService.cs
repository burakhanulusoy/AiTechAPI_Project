using AiTech.WebUI.DTOs.AboutDtos;
using Newtonsoft.Json;
using System.Text;

namespace AiTech.WebUI.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly HttpClient _client;

        public AboutService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7203/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateAboutDto createAboutDto)
        {
           var json=JsonConvert.SerializeObject(createAboutDto);

           var content = new StringContent(json, Encoding.UTF8, "application/json");
        
           await _client.PostAsync("abouts", content);



        }

        public async Task DeleteAsync(int id)
        {

            await _client.DeleteAsync("abouts/" + id);

        }

        public async Task<List<ResultAboutDto>> GetAllAsync()
        {

            var response = await _client.GetAsync("abouts");
            if(!response.IsSuccessStatusCode)
            {
                throw new Exception("Hakkımızda Listesi Getirilemedi !");

            }
            var jsonContent=await response.Content.ReadAsStringAsync();
            var values=JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonContent);
            return values;



        }

        public async Task<UpdateAboutDto> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync("abouts/" + id);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Hakkımzda değeri getirilemedi");
            }
            var jsonContent=await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<UpdateAboutDto>(jsonContent);
            return values;




        }

        public async Task UpdateAsync(UpdateAboutDto updateAboutDto)
        {
           
            var json=JsonConvert.SerializeObject(updateAboutDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _client.PutAsync("abouts", content);


        }
    }
}
