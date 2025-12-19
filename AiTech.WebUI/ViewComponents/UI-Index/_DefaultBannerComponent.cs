using AiTech.WebUI.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.WebUI.ViewComponents.UI_Index
{
    public class _DefaultBannerComponent(IBannerService _bannerService):ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var item=(await _bannerService.GetAllBannerAsync()).OrderByDescending(x=>x.Id).FirstOrDefault();
            return View(item);

        }












    }
}
