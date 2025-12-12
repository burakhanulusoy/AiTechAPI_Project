using AiTech.WebUI.DTOs.CategoryDto;

namespace AiTech.WebUI.Services.CategoryServices
{
    public interface ICategoryService
    {

        Task<List<ResultCategoryDto>> GetAllCategoriesAsync();
        Task<UpdateCategoryDto> GetCategoryByIdAsync(int id);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task DeleteCategoryAsync(int id);




    }
}
