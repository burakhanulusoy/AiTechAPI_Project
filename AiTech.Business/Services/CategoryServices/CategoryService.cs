using AiTech.DataAccess.Repositories.CategoryRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.CategoryDtos;
using AiTech.Entity.Entities;
using Mapster;

namespace AiTech.Business.Services.CategoryServices
{
    public class CategoryService(ICategoryRepository _categoryRepository
                                ,IUnitOfWork _unitOfWork ) : ICategoryService
    {
        public async Task TCreateAsync(CreateCategoryDto createDto)
        {
            var category = createDto.Adapt<Category>();
            await _categoryRepository.CreateAsync(category);
            await _unitOfWork.SaveChangesAsync();

        }

        public async Task TDelete(int id)
        {
            var category=await _categoryRepository.GetByIdAsync(id);
            if(category is null)
            {
                throw new Exception("Kategori bulunamadý");
            }
            _categoryRepository.Delete(category);
            await _unitOfWork.SaveChangesAsync();


        }

        public async Task<List<ResultCategoryDto>> TGetAllAsync()
        {
            var categories=await _categoryRepository.GetAllAsync();
            return categories.Adapt<List<ResultCategoryDto>>();



        }

        public async Task<ResultCategoryDto> TGetByIdAsync(int id)
        {
            var category=await _categoryRepository.GetByIdAsync(id);
            if(category is null)
            {
                throw new Exception("Kategori bulunamadý");
            }
            return category.Adapt<ResultCategoryDto>();




        }

        public async Task TUpdate(UpdateCategoryDto updateDto)
        {
            var category=updateDto.Adapt<Category>();
            _categoryRepository.Update(category);
            await _unitOfWork.SaveChangesAsync();





        }
    }
}
