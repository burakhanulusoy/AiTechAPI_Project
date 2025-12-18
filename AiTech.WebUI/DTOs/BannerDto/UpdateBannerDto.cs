namespace AiTech.WebUI.DTOs.BannerDto
{
    public class UpdateBannerDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
