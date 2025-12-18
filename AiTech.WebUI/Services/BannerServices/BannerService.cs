using AiTech.WebUI.DTOs.BannerDto;

namespace AiTech.WebUI.Services.BannerServices
{
    public class BannerService : IBannerService
    {

        private readonly HttpClient _client;

        public BannerService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7203/api/");
            _client = client;
        }

        public async Task CreateBannerAsync(CreateBannerDto createBannerDto)
        {
            await _client.PostAsJsonAsync("banners", createBannerDto);

        }

        public async Task DeleteBannerAsync(int id)
        {
            await _client.DeleteAsync("banners/" + id);
        }

        public async Task<List<ResultBannerDto>> GetAllBannerAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultBannerDto>>("banners");
        }

        public async Task<UpdateBannerDto> GetBannerAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateBannerDto>("banners/" + id);
        }

        public async Task MakeActiveBannerAsync(int id)
        {
            await _client.PatchAsync("banners/makeActive/"+id,null);

        }

        public async Task MakePassiveBannerAsync(int id)
        {
            await _client.PatchAsync("banners/makePassive/"+ id, null);

        }

        public async Task UpdateBannerAsync(UpdateBannerDto updateBannerDto)
        {
            await _client.PutAsJsonAsync("banners", updateBannerDto);
        }
    }
}
