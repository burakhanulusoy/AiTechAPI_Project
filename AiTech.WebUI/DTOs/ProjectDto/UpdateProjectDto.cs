namespace AiTech.WebUI.DTOs.ProjectDto
{
    public class UpdateProjectDto
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Subject { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
