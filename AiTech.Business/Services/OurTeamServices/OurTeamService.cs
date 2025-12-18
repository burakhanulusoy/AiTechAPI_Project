using AiTech.DataAccess.Repositories.OurTeamRepositories;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.OurTeamDtos;
using AiTech.Entity.Entities;
using Mapster;

namespace AiTech.Business.Services.OurTeamServices
{
    public class OurTeamService(IOurTeamRepository _ourTeamRepository,IUnitOfWork _unitOfWork) : IOurTeamService
    {
        public async Task TCreateAsync(CreateOurTeamDto createDto)
        {
            var item = createDto.Adapt<OurTeam>();
            await _ourTeamRepository.CreateAsync(item);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDelete(int id)
        {
          var item = await _ourTeamRepository.GetByIdAsync(id);
            if(item is null)
            {
                throw new Exception("Bulunamadý");
            }
            _ourTeamRepository.Delete(item);
            await _unitOfWork.SaveChangesAsync();


        }

        public async Task<List<ResultOurTeamDto>> TGetAllAsync()
        {
            var items=await _ourTeamRepository.GetAllAsync();
            return items.Adapt<List<ResultOurTeamDto>>();
        }

        public async Task<ResultOurTeamDto> TGetByIdAsync(int id)
        {
            
            var item =await _ourTeamRepository.GetByIdAsync(id);
            return item.Adapt<ResultOurTeamDto>();


        }

        public async Task TUpdate(UpdateOurTeamDto updateDto)
        {
            var item=updateDto.Adapt<OurTeam>();
            _ourTeamRepository.Update(item);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
