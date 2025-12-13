using AiTech.DTO.CategoryDtos;

namespace AiTech.DTO.ProjectDtos
{
    public record ResultProjectDto(

        int Id,
        string Title,
        string Subject,
        string ImageUrl,
        int CategoryId,
        ResultCategoryDto Category


        );
    
}
