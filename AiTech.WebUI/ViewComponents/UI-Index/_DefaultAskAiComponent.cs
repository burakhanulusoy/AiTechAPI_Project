using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUI.Components.UI_Index
{
    public class _DefaultAskAiComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();

        }


    }
}
