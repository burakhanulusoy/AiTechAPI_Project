namespace AiTech.Business.Services.GenericServices
{
    public interface IGenericService<TResultDto, TCreateDto, TUpdateDto>
    {
        Task<List<TResultDto>> TGetAllAsync();
        Task<TResultDto> TGetByIdAsync(int id);
        Task TCreateAsync(TCreateDto createDto);
        Task TUpdate(TUpdateDto updateDto);
        Task TDelete(int id);



    }
}
