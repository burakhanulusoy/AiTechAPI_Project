using AiTech.WebUI.DTOs.TestimonialsDtos;

namespace AiTech.WebUI.Services.TestimonialServices
{
    public interface ITestimonailService
    {
        Task<List<ResultTestimonialDto>> GetAllAsync();
        Task<UpdateTestimonialDto> GetByIdAsync(int id);
        Task UpdateAsync(UpdateTestimonialDto updateTestimonialDto);
        Task CreateAsync(CreateTestimonialDto createTestimonialDto);
        Task DeleteAsync(int id);





    }
}
