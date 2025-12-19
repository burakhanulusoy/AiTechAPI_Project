using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUI.ViewComponents.UI_Index
{
    public class _DefaultServicesComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           
            return  View();
        }






    }
}
