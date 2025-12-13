using AiTech.WebUI.DTOs.CategoryDto;
using AiTech.WebUI.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CategoryController(ICategoryService _categoryService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();

            return View(categories);
        }
        public IActionResult CreateCategory()
        {
                       return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            if(!ModelState.IsValid)
            {
                return View(createCategoryDto);
            }
            await _categoryService.CreateCategoryAsync(createCategoryDto);
            return RedirectToAction("Index");



        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryService.DeleteCategoryAsync(id);
            return RedirectToAction("Index");


        }

        public async Task<IActionResult> UpdateCategory(int id)
        {
            var category=await _categoryService.GetCategoryByIdAsync(id);
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            if(!ModelState.IsValid)
            {
                 return View(updateCategoryDto);
            }
            await _categoryService.UpdateCategoryAsync(updateCategoryDto);
            return RedirectToAction("Index");


        }
















    }
}
