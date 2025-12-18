using AiTech.WebUI.DTOs.AboutDtos;
using AiTech.WebUI.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController(IAboutService _aboutService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var abouts=await _aboutService.GetAllAsync();
            return View(abouts);
        }
        public async Task<IActionResult> DeleteAbout(int id)
        {
            await _aboutService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDto createAboutDto)
        {
            if(!ModelState.IsValid)
            {
                return View(createAboutDto);
            }


            await _aboutService.CreateAsync(createAboutDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateAbout(int id)
        {
            var about=await _aboutService.GetByIdAsync(id);
            return View(about);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            if (!ModelState.IsValid)
            {
                return View(updateAboutDto);
            }

            await _aboutService.UpdateAsync(updateAboutDto);
            return RedirectToAction(nameof(Index));
        }








    }
}
