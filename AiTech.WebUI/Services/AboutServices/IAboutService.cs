using AiTech.WebUI.DTOs.AboutDtos;

namespace AiTech.WebUI.Services.AboutServices
{
    public interface IAboutService
    {

        Task<List<ResultAboutDto>> GetAllAsync();
        Task<UpdateAboutDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateAboutDto updateAboutDto);
        Task CreateAsync(CreateAboutDto createAboutDto);






    }
}
