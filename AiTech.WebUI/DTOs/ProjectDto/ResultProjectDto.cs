using AiTech.WebUI.DTOs.CategoryDto;

namespace AiTech.WebUI.DTOs.ProjectDto
{
    public class ResultProjectDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public ResultCategoryDto Category { get; set; }






    }
}
