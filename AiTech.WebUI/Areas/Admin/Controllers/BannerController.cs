using AiTech.WebUI.DTOs.BannerDto;
using AiTech.WebUI.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController(IBannerService _bannerService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var banners=await _bannerService.GetAllBannerAsync();
            return View(banners);
        }

        public async Task<IActionResult> DeleteBanner(int id)
        {
            await _bannerService.DeleteBannerAsync(id);
            return RedirectToAction("Index");
        }

        public IActionResult CreateBanner()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerDto createBannerDto)
        { 
           
            if(!ModelState.IsValid)
            {
                return View(createBannerDto);
            }
            await _bannerService.CreateBannerAsync(createBannerDto);
            return RedirectToAction("Index");

          

        }
        public async Task<IActionResult> UpdateBanner(int id)
        {
            var banner=await _bannerService.GetBannerAsync(id);
            return View(banner);


        }

        [HttpPost]
        public async Task<IActionResult> UpdateBanner(UpdateBannerDto updateBannerDto)
        {

            if(!ModelState.IsValid)
            {
                return View(updateBannerDto);
            }

            await _bannerService.UpdateBannerAsync(updateBannerDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> MakeActive(int id)
        {
            await _bannerService.MakeActiveBannerAsync(id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> MakePassive(int id)
        {
            await _bannerService.MakePassiveBannerAsync(id);
            return RedirectToAction("Index");
        }











    }
}
