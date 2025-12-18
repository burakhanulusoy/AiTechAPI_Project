using AiTech.WebUI.DTOs.WhyChoiseDtos;
using AiTech.WebUI.Services.WhyChoiceServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WhyChoiceController(IWhyChoiceService _whyChoiceService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var items=await _whyChoiceService.GetAllAsync();
            return View(items);
        }
        public async Task<IActionResult> DeleteWhyChoice(int id)
        {
            await _whyChoiceService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
        public IActionResult CreateWhyChoice()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateWhyChoice(CreateWhyChoiseDto createWhyChoiseDto)
        {
            if(!ModelState.IsValid)
            {
                return View(createWhyChoiseDto);
            }
            await _whyChoiceService.CreateAsync(createWhyChoiseDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateWhyChoice(int id)
        {
            var item=await _whyChoiceService.GetByIdAsync(id);
            return View(item);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateWhyChoice(UpdateWhyChoiseDto updateWhyChoiseDto)
        {
            if(!ModelState.IsValid)
            {
                return View(updateWhyChoiseDto);
            }
            await _whyChoiceService.UpdateAsync(updateWhyChoiseDto);
            return RedirectToAction(nameof(Index));

        }



    }
}
