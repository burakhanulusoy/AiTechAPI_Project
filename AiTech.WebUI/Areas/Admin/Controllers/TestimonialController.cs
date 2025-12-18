using AiTech.WebUI.DTOs.TestimonialsDtos;
using AiTech.WebUI.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController(ITestimonailService _testimonailService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var items=await _testimonailService.GetAllAsync();
            return View(items);
        }
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            await _testimonailService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
        public IActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            if(!ModelState.IsValid)
            {
                return View(createTestimonialDto);
            }
            await _testimonailService.CreateAsync(createTestimonialDto);
            return RedirectToAction("Index");
        
        }
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var item =await _testimonailService.GetByIdAsync(id);
            return View(item);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            if(!ModelState.IsValid)
            {
                return View(updateTestimonialDto);
            }
            await _testimonailService.UpdateAsync(updateTestimonialDto);
            return RedirectToAction("Index");
        }

















    }
}
