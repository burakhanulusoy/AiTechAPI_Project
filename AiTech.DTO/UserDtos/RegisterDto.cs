using System.ComponentModel.DataAnnotations;

namespace AiTech.DTO.UserDtos
{
    public class RegisterDto
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Þifreler birbiri ile uyumsuz kontrol ediniz.")]
        public string ConfirmPassword { get; set; }
        public string ImageUrl { get; set; }


    }
}
