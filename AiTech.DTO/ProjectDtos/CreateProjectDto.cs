using AiTech.DTO.CategoryDtos;

namespace AiTech.DTO.ProjectDtos
{
    public record CreateProjectDto(
        string Title,
        string Subject,
        string ImageUrl,
        int CategoryId
     

        );
    
}
