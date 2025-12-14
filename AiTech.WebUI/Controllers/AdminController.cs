using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
