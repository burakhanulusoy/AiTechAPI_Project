using AiTech.WebUI.DTOs.ProjectDto;

namespace AiTech.WebUI.Services.ProjectServices
{
    public interface IProjectService
    {

        Task<List<ResultProjectDto>> GetAllProjectsWithCategoriesAsync();
        Task<UpdateProjectDto> GetProjectByIdAsync(int id);
        Task CreateProjectAsync(CreateProjectDto createProjectDto);
        Task UpdateProjectAsync(UpdateProjectDto updateProjectDto);
        Task DeleteProjectAsync(int id);




    }
}
