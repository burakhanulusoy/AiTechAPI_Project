using AiTech.Business.Services.GenericServices;
using AiTech.DTO.ProjectDtos;

namespace AiTech.Business.Services.ProjectServices
{
    public interface IProjectService:IGenericService<ResultProjectDto,CreateProjectDto,UpdateProjectDto>
    {

        Task<List<ResultProjectDto>> TGetProjectsWithCategories();

    }
}
