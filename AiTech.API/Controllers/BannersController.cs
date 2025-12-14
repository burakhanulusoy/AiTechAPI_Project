using AiTech.Business.Services.BannerServices;
using AiTech.DTO.BannerDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IBannerService _bannerService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var banners = await _bannerService.TGetAllAsync();
            return Ok(banners);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var banner=await _bannerService.TGetByIdAsync(id);
            if(banner is null)
            {
                return BadRequest("Banner bulunamadı.");//400 durum kodu döner
            }
            return Ok(banner);


        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _bannerService.TDelete(id);
            return NoContent();


        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBannerDto createBannerDto)
        { 
           await _bannerService.TCreateAsync(createBannerDto);
            return Created();

        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateBannerDto updateBannerDto)
        {
            await _bannerService.TUpdate(updateBannerDto);
            return NoContent();
        }

        [HttpPatch("makeActive/{id}")]
        public async Task<IActionResult> MakeActive(int id)
        {
            await _bannerService.TMakeActiveAsync(id);
            return NoContent();


        }
        [HttpPatch("makePassive/{id}")]
        public async Task<IActionResult> MakePassive(int id)
        {
            await _bannerService.TMakePassiveAsync(id);
            return NoContent();


        }



    }
}
