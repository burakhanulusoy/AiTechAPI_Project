using AiTech.DTO.UserDtos;
using AiTech.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistersController(UserManager<AppUser> _userManager) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateUser(RegisterDto registerDto)
        {
            var user = new AppUser
            {
                FullName = registerDto.FullName,
                Email = registerDto.Email,
                UserName = registerDto.UserName,
                ImageUrl = registerDto.ImageUrl
            };

            var result = await _userManager.CreateAsync(user, registerDto.Password);
            if(!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            return NoContent();
        }


    }
}
