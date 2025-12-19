using AiTech.WebUI.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.WebUI.ViewComponents.UI_Index
{
    public class _DefaultTestimonialComponent(ITestimonailService _testimonailService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items=await _testimonailService.GetAllAsync();
            return View(items);
        }





    }
}
