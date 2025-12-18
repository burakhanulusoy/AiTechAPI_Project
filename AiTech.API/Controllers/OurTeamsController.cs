using AiTech.Business.Services.OurTeamServices;
using AiTech.DTO.OurTeamDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OurTeamsController(IOurTeamService _ourTeamService) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items=await _ourTeamService.TGetAllAsync();
            return Ok(items);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _ourTeamService.TDelete(id);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateOurTeamDto createOurTeamDto)
        {
            await _ourTeamService.TCreateAsync(createOurTeamDto);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateOurTeamDto updateOurTeamDto)
        {
            await _ourTeamService.TUpdate(updateOurTeamDto);
            return NoContent();

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item=await _ourTeamService.TGetByIdAsync(id);
            if(item is null)
            {
                return BadRequest("Başarısız Bulunamadı");
            }
            return Ok(item);


        }








    }
}
