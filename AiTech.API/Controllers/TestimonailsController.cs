using AiTech.Business.Services.TestimonailServices;
using AiTech.DTO.TestimonialDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonailsController(ITestimonailService _testimonailService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values=await _testimonailService.TGetAllAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value=await _testimonailService.TGetByIdAsync(id);
            if(value is null)
            {
                return BadRequest("Bulunamadı");
            }
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _testimonailService.TDelete(id);
            return NoContent();

        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateTestimonialDto createTestimonialDto)
        {
            await _testimonailService.TCreateAsync(createTestimonialDto);
            return Created();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateTestimonialDto updateTestimonialDto)
        {
            await _testimonailService.TUpdate(updateTestimonialDto);
            return NoContent();
        }








    }
}
