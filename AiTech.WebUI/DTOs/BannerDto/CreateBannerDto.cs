namespace AiTech.WebUI.DTOs.BannerDto
{
    public class CreateBannerDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
