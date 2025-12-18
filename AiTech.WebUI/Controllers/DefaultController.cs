using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
