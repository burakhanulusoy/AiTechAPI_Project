using AiTech.Business.Services.AboutServices;
using AiTech.DTO.AboutDtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IAboutService _aboutService) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var abouts=await _aboutService.TGetAllAsync();
            return Ok(abouts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var about=await _aboutService.TGetByIdAsync(id);
            if(about is null)
            {
                return BadRequest("Hakkımızda bilgisi bulunamadı.");
            }

            return Ok(about);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _aboutService.TDelete(id);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutDto createAboutDto)
        {
            await _aboutService.TCreateAsync(createAboutDto);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutDto updateAboutDto)
        {
            await _aboutService.TUpdate(updateAboutDto);
            return NoContent();
        }



















    }
}
