using AiTech.WebUI.DTOs.WhyChoiseDtos;

namespace AiTech.WebUI.Services.WhyChoiceServices
{
    public interface IWhyChoiceService
    {

        Task<List<ResultWhyChoiseDto>> GetAllAsync();
        Task<UpdateWhyChoiseDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateWhyChoiseDto updateWhyChoiseDto);
        Task CreateAsync(CreateWhyChoiseDto createWhyChoiseDto);
    }
}
