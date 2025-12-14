using AiTech.DataAccess.Repositories.BannerRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.BannerDtos;
using AiTech.Entity.Entities;
using Mapster;

namespace AiTech.Business.Services.BannerServices
{
    public class BannerService(IBannerRepository _bannerRepository,IUnitOfWork _unitOfWork) : IBannerService
    {
        public async Task TCreateAsync(CreateBannerDto createDto)
        {
            var banner = createDto.Adapt<Banner>();
            await _bannerRepository.CreateAsync(banner);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDelete(int id)
        {
           
            var banner=await _bannerRepository.GetByIdAsync(id);

            if(banner is null)
            {
                throw new Exception("Banner bulunamadý");
            }


            _bannerRepository.Delete(banner);
            await _unitOfWork.SaveChangesAsync();


        }

        public async Task<List<ResultBannerDto>> TGetAllAsync()
        {

            var banners=await _bannerRepository.GetAllAsync();
            return banners.Adapt<List<ResultBannerDto>>();


        }

        public async Task<ResultBannerDto> TGetByIdAsync(int id)
        {
            var banner=await _bannerRepository.GetByIdAsync(id);
            return banner.Adapt<ResultBannerDto>();



        }

        public async Task TMakeActiveAsync(int id)
        {
           var banner=await _bannerRepository.GetByIdAsync(id);
           if(banner is null)
           {
                throw new Exception("Banner bulunamadý");
           }
           await _bannerRepository.MakeActiveAsync(banner);
           await _unitOfWork.SaveChangesAsync();




        }

        public async Task TMakePassiveAsync(int id)
        {
            var banner=await _bannerRepository.GetByIdAsync(id);
            if(banner is null)
            {
                throw new Exception("Banner bulunamadý");
            }
            await _bannerRepository.MakePassiveAsync(banner);
            await _unitOfWork.SaveChangesAsync();


        }

        public Task TUpdate(UpdateBannerDto updateDto)
        {
            var banner=updateDto.Adapt<Banner>();
            _bannerRepository.Update(banner);
            return _unitOfWork.SaveChangesAsync();


        }
    }
}
