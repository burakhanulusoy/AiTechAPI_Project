using AiTech.Business.Services.CategoryServices;
using AiTech.DTO.CategoryDtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDto categoryDto)
        {
            await _categoryService.TCreateAsync(categoryDto);
            return Ok("Kategori başarıyla oluşturuldu.");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCategoryDto categoryDto)
        {
            await _categoryService.TUpdate(categoryDto);
            return Ok("Kategori başarıyla güncellendi.");
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryService.TDelete(id);
            return Ok("Kategori başarıyla silindi.");
        }

















    }
}
