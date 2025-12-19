using AiTech.WebUI.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.WebUI.ViewComponents.UI_Index
{
    public class _DefaultAboutUsComponent(IAboutService _aboutService):ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var item=(await _aboutService.GetAllAsync()).OrderByDescending(x=>x.Id).FirstOrDefault();
            return View(item);

        }



    }
}
