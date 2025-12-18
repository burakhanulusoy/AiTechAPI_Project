using AiTech.WebUI.DTOs.WhyChoiseDtos;
using Newtonsoft.Json;
using System.Text;

namespace AiTech.WebUI.Services.WhyChoiceServices
{
    public class WhyChoiceService : IWhyChoiceService
    {
        private readonly HttpClient _client;

        public WhyChoiceService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7203/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateWhyChoiseDto createWhyChoiseDto)
        {
            var json=JsonConvert.SerializeObject(createWhyChoiseDto);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            await _client.PostAsync("whychoices", content);

        }

        public async Task DeleteAsync(int id)
        {

            await _client.DeleteAsync("whychoices/" + id);


        }

        public async Task<List<ResultWhyChoiseDto>> GetAllAsync()
        {
            var response = await _client.GetAsync("whychoices");
            
            if(!response.IsSuccessStatusCode)
            {
                throw new Exception("kategori listesi bulunamadı");
            }
            var jsonContent=await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultWhyChoiseDto>>(jsonContent);
            return values;





        }

        public async Task<UpdateWhyChoiseDto> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync("whychoices/" + id);
            if(!response.IsSuccessStatusCode)
            {
                throw new Exception("bulunamadı");
            }
            var jsonContent=await response.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<UpdateWhyChoiseDto>(jsonContent);
            return value;


        }

        public async Task UpdateAsync(UpdateWhyChoiseDto updateWhyChoiseDto)
        {
           
            var json=JsonConvert.SerializeObject(updateWhyChoiseDto);

            var content=new StringContent(json,Encoding.UTF8, "application/json");

            await _client.PutAsync("whychoices", content);




        }
    }
}
