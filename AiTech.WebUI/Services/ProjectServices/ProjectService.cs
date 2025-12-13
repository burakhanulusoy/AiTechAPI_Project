using AiTech.WebUI.DTOs.ProjectDto;

namespace AiTech.WebUI.Services.ProjectServices
{
    public class ProjectService : IProjectService
    {

        private readonly HttpClient _client;

        public ProjectService(HttpClient client)
        {
            client.BaseAddress=new Uri("https://localhost:7203/api/");


            _client = client;
        }

        public async Task CreateProjectAsync(CreateProjectDto createProjectDto)
        {
            await _client.PostAsJsonAsync("Projects", createProjectDto);


        }

        public async Task DeleteProjectAsync(int id)
        {
            await _client.DeleteAsync("Projects/" + id);
        }

        public async Task<List<ResultProjectDto>> GetAllProjectsWithCategoriesAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultProjectDto>>("Projects/GetProjectsWithCategory");

        }

        public async Task<UpdateProjectDto> GetProjectByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateProjectDto>("Projects/" + id);
        }

        public async Task UpdateProjectAsync(UpdateProjectDto updateProjectDto)
        {
            await _client.PutAsJsonAsync("Projects", updateProjectDto); 
        }
    }
}
