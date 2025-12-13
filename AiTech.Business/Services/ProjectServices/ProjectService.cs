using AiTech.DataAccess.Repositories.ProjectRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.ProjectDtos;
using AiTech.Entity.Entities;
using Mapster;

namespace AiTech.Business.Services.ProjectServices
{
    public class ProjectService(IProjectRepository _projectRepository
                                ,IUnitOfWork _unitOfWork) : IProjectService
    {
        public async Task TCreateAsync(CreateProjectDto createDto)
        {

            var project = createDto.Adapt<Project>();
            await _projectRepository.CreateAsync(project);
            await _unitOfWork.SaveChangesAsync();



        }

        public async Task TDelete(int id)
        {
            var project=await _projectRepository.GetByIdAsync(id);
            if (project is null)
            {
                throw new Exception("Proje bulunamadý !");
            }
             _projectRepository.Delete(project);
            await _unitOfWork.SaveChangesAsync();



        }

        public async Task<List<ResultProjectDto>> TGetAllAsync()
        {

            var projects = await _projectRepository.GetAllAsync();
            
            return projects.Adapt<List<ResultProjectDto>>();


        }

        public async Task<ResultProjectDto> TGetByIdAsync(int id)
        {

            var project = await _projectRepository.GetByIdAsync(id);
           
            return project.Adapt<ResultProjectDto>();


        }

        public async Task<List<ResultProjectDto>> TGetProjectsWithCategories()
        {
            var projects = await _projectRepository.GetProjectsWithCategories();
            return projects.Adapt<List<ResultProjectDto>>();


        }

        public async Task TUpdate(UpdateProjectDto updateDto)
        {
            var project=updateDto.Adapt<Project>();
            _projectRepository.Update(project);
            await _unitOfWork.SaveChangesAsync();



        }
    }
}
