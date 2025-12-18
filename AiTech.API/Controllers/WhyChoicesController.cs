using AiTech.Business.Services.WhyChoiseServices;
using AiTech.DTO.WhyChoiseDtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhyChoicesController(IWhyChoiseService _whyChoiseService) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values=await _whyChoiseService.TGetAllAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value=await _whyChoiseService.TGetByIdAsync(id);
            if(value is null)
            {
                return BadRequest("Bulunamadı.");
            }


            return Ok(value);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _whyChoiseService.TDelete(id);
            return NoContent();

        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateWhyChoiseDto createWhyChoiseDto)
        {
            await _whyChoiseService.TCreateAsync(createWhyChoiseDto);
            return Created();

        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateWhyChoiseDto updateWhyChoiseDto)
        {
            await _whyChoiseService.TUpdate(updateWhyChoiseDto);
            return NoContent();

        }




    }
}
