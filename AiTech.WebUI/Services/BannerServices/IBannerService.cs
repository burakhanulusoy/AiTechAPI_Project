using AiTech.WebUI.DTOs.BannerDto;

namespace AiTech.WebUI.Services.BannerServices
{
    public interface IBannerService
    {

        Task<List<ResultBannerDto>> GetAllBannerAsync();
        Task<ResultBannerDto> GetBannerAsync(int id);
        Task CreateBannerAsync(CreateBannerDto createBannerDto);
        Task UpdateBannerAsync(UpdateBannerDto updateBannerDto);
        Task DeleteBannerAsync(int id);
        Task MakeActiveBannerAsync(int id);
        Task MakePassiveBannerAsync(int id);

    }
}
