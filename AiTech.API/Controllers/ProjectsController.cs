using AiTech.Business.Services.ProjectServices;
using AiTech.DTO.ProjectDtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController(IProjectService _projectService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var projects=await _projectService.TGetAllAsync();
            return Ok(projects);
        }


         [HttpGet("GetProjectsWithCategory")]
         public async Task<IActionResult> GetAllWithCategories()
         {
            var prjects=await _projectService.TGetProjectsWithCategories();
            return Ok(prjects);

         }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var project=await _projectService.TGetByIdAsync(id);
            if(project is null)
            {
                return BadRequest("Proje bulunamadı.");//400 durum kodu döner
            }
            return Ok(project);

        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProjectDto projectDto)
        {
            await _projectService.TCreateAsync(projectDto);
            return Created();

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _projectService.TDelete(id);
            return NoContent();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateProjectDto updateProject)
        {
            await _projectService.TUpdate(updateProject);
            return NoContent();
        }









    }
}
