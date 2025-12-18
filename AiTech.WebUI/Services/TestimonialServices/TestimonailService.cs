using AiTech.WebUI.DTOs.TestimonialsDtos;

namespace AiTech.WebUI.Services.TestimonialServices
{
    public class TestimonailService : ITestimonailService
    {

        private readonly HttpClient _client;

        public TestimonailService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7203/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateTestimonialDto createTestimonialDto)
        {
           await _client.PostAsJsonAsync("testimonails",createTestimonialDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("testimonails/" + id);
        }

        public async Task<List<ResultTestimonialDto>> GetAllAsync()
        {
            var testimonails = await _client.GetFromJsonAsync<List<ResultTestimonialDto>>("testimonails");
            return testimonails;
        }

        public async Task<UpdateTestimonialDto> GetByIdAsync(int id)
        {
            var testimonial = await _client.GetFromJsonAsync<UpdateTestimonialDto>("testimonails/" + id);
            return testimonial;
        }

        public async Task UpdateAsync(UpdateTestimonialDto updateTestimonialDto)
        {
            await _client.PutAsJsonAsync("testimonails", updateTestimonialDto);
        }
    }
}
