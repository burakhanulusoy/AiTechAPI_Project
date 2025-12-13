using AiTech.DTO.CategoryDtos;

namespace AiTech.DTO.ProjectDtos
{
    public record UpdateProjectDto(

         int Id,
        string Title,
        string Subject,
        string ImageUrl,
        int CategoryId
      

        );


}
