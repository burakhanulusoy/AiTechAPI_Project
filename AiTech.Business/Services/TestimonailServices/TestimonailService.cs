using AiTech.DataAccess.Repositories.TestimonialRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.TestimonialDtos;
using AiTech.Entity.Entities;
using Mapster;

namespace AiTech.Business.Services.TestimonailServices
{
    public class TestimonailService(ITestimonialRepository _testimonialRepository,IUnitOfWork _unitOfWork) : ITestimonailService
    {
        public async Task TCreateAsync(CreateTestimonialDto createDto)
        {
            var value = createDto.Adapt<Testimonial>();
            await _testimonialRepository.CreateAsync(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDelete(int id)
        {
            var value=await _testimonialRepository.GetByIdAsync(id);
            if(value is null)
            {
                throw new Exception("Bulunamadý");
            }
            _testimonialRepository.Delete(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultTestimonialDto>> TGetAllAsync()
        {
            var items=await _testimonialRepository.GetAllAsync();
            return items.Adapt<List<ResultTestimonialDto>>();
        }

        public async Task<ResultTestimonialDto> TGetByIdAsync(int id)
        {
            var item = await _testimonialRepository.GetByIdAsync(id);
            return item.Adapt<ResultTestimonialDto>();
        }

        public async Task TUpdate(UpdateTestimonialDto updateDto)
        {
          
            var value=updateDto.Adapt<Testimonial>();
            _testimonialRepository.Update(value);
            await _unitOfWork.SaveChangesAsync();

        }
    
    
    
    }
}
