using AiTech.WebUI.DTOs.OurTeamDtos;
using AiTech.WebUI.Services.OurTeamServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OurTeamController(IOurTeamService _ourTeamService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _ourTeamService.GetAllAsync();
            return View(values);
        }
        public async Task<IActionResult> DeleteOurTeam(int id)
        {
            await _ourTeamService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
        public IActionResult CreateOurTeam()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateOurTeam(CreateOurTeamDto createOurTeamDto)
        {
            if(!ModelState.IsValid)
            {
                return View(createOurTeamDto);
            }
            await _ourTeamService.CreateAsync(createOurTeamDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateOurTeam(int id)
        {
            var value=await _ourTeamService.GetByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateOurTeam(UpdateOurTeamDto updateOurTeamDto)
        {
            if(!ModelState.IsValid)
            {
                return View(updateOurTeamDto);
            }
            await _ourTeamService.UpdateAsync(updateOurTeamDto);
            return RedirectToAction("Index");
        }





    }
}
