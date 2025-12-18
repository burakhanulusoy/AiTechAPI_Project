using AiTech.DataAccess.Repositories.AboutRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.AboutDtos;
using AiTech.Entity.Entities;
using Mapster;

namespace AiTech.Business.Services.AboutServices
{
    public class AboutService(IAboutRepository _aboutRepository,IUnitOfWork _unitOfWork) : IAboutService
    {
        public async Task TCreateAsync(CreateAboutDto createDto)
        {
            var aboutItem = createDto.Adapt<About>();
            await _aboutRepository.CreateAsync(aboutItem);
            await _unitOfWork.SaveChangesAsync();



        }

        public async Task TDelete(int id)
        {
            var aboutItem=await _aboutRepository.GetByIdAsync(id);
            if(aboutItem == null)
            {
                throw new Exception("Hakkýmýzda bilgisi bulunamadý!");
            }
            _aboutRepository.Delete(aboutItem);
            await _unitOfWork.SaveChangesAsync();



        }

        public async Task<List<ResultAboutDto>> TGetAllAsync()
        {
            var allAbouts=await _aboutRepository.GetAllAsync();
            return allAbouts.Adapt<List<ResultAboutDto>>();


        }

        public async Task<ResultAboutDto> TGetByIdAsync(int id)
        {
            var about=await _aboutRepository.GetByIdAsync(id);
            return about.Adapt<ResultAboutDto>();



        }

        public async Task TUpdate(UpdateAboutDto updateDto)
        {
            var about=updateDto.Adapt<About>();
            _aboutRepository.Update(about);
            await _unitOfWork.SaveChangesAsync();


        }
    }
}
