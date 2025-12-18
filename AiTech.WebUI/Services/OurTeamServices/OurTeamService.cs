using AiTech.WebUI.DTOs.OurTeamDtos;
using Newtonsoft.Json;
using System.Text;

namespace AiTech.WebUI.Services.OurTeamServices
{
    public class OurTeamService : IOurTeamService
    {
        private readonly HttpClient _client;

        public OurTeamService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7203/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateOurTeamDto createOurTeamDto)
        {
           var json=JsonConvert.SerializeObject(createOurTeamDto);
           var content = new StringContent(json, Encoding.UTF8, "application/json");
           await _client.PostAsync("ourteams", content); 



        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("ourteams/" + id);
        }

        public async Task<List<ResultOurTeamDto>> GetAllAsync()
        {
            var response = await _client.GetAsync("ourteams");
            if(response is null)
            {
                throw new Exception("Liste getirilemedi");
            }
            var content=await response.Content.ReadAsStringAsync();
            var values=JsonConvert.DeserializeObject<List<ResultOurTeamDto>>(content);
            return values;



        }

        public async Task<UpdateOurTeamDto> GetByIdAsync(int id)
        {
            var response = await _client.GetAsync("ourteams/" + id);
            if(response is null)
            {
                throw new Exception("Başarısız");
            }
            var content= await response.Content.ReadAsStringAsync();
            var value=JsonConvert.DeserializeObject<UpdateOurTeamDto>(content);
            return value;




        }

        public async Task UpdateAsync(UpdateOurTeamDto updateOurTeamDto)
        {
            var json=JsonConvert.SerializeObject(updateOurTeamDto);
            var content=new StringContent(json,Encoding.UTF8,"application/json");
            await _client.PutAsync("ourteams", content);


        }
    }
}
