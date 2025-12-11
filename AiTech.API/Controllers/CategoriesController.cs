using AiTech.Business.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController(ICategoryService _categoryService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories=await _categoryService.TGetAllAsync();
            return Ok(categories);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category=await _categoryService.TGetByIdAsync(id);
            return Ok(category);
        }
























    }
}
