using AiTech.DataAccess.Repositories.WhyChoiseRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.WhyChoiseDtos;
using AiTech.Entity.Entities;
using Mapster;

namespace AiTech.Business.Services.WhyChoiseServices
{
    public class WhyChoiseService(IWhyChoiseRepository _whyChoiseRepository
                                  ,IUnitOfWork _unitOfWork) : IWhyChoiseService
    {
        public async Task TCreateAsync(CreateWhyChoiseDto createDto)
        {
            var item = createDto.Adapt<WhyChoise>();
            await _whyChoiseRepository.CreateAsync(item);
            await _unitOfWork.SaveChangesAsync();


        }

        public async Task TDelete(int id)
        {
            var choice = await _whyChoiseRepository.GetByIdAsync(id);
           if(choice is null)
           {
                throw new Exception("Hata oluþtu");
           }
             _whyChoiseRepository.Delete(choice);
            await _unitOfWork.SaveChangesAsync();



        }

        public async Task<List<ResultWhyChoiseDto>> TGetAllAsync()
        {
            var items = await _whyChoiseRepository.GetAllAsync();
            var values = items.Adapt<List<ResultWhyChoiseDto>>();
            return values;



        }

        public async Task<ResultWhyChoiseDto> TGetByIdAsync(int id)
        {
            var item = await _whyChoiseRepository.GetByIdAsync(id);
            var values = item.Adapt<ResultWhyChoiseDto>();

            return values;
        }

        public async Task TUpdate(UpdateWhyChoiseDto updateDto)
        {
           var item=updateDto.Adapt<WhyChoise>();
           _whyChoiseRepository.Update(item);
            await _unitOfWork.SaveChangesAsync();


        }
    }
}
