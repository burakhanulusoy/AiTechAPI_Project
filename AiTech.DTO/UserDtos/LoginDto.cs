using System.ComponentModel.DataAnnotations;

namespace AiTech.DTO.UserDtos
{
    public class LoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Þifreler birbiri ile uyumsuz kontrol ediniz.")]
        public string ConfirmPassword { get; set; }


    }
}
