using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
