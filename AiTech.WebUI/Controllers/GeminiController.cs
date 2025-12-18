using AiTech.WebUI.Services.GemineServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.WebUI.Controllers
{
    public class GeminiController(IGeminiService _geminiService) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string prompt)
        {
            var response=await _geminiService.GenerateGeminiAsync(prompt);
            if(response is not null)
            {
                ViewBag.response = response;
            }

            return View();


        }



    }
}
