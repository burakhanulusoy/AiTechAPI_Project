using AiTech.WebUI.DTOs.OurTeamDtos;

namespace AiTech.WebUI.Services.OurTeamServices
{
    public interface IOurTeamService
    {
        Task<List<ResultOurTeamDto>> GetAllAsync();
        Task<UpdateOurTeamDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateOurTeamDto updateOurTeamDto);
        Task CreateAsync(CreateOurTeamDto createOurTeamDto);
    }
}
