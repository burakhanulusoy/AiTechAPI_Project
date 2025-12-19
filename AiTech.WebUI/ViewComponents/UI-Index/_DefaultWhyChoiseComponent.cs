using AiTech.WebUI.Services.WhyChoiceServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.WebUI.ViewComponents.UI_Index
{
    public class _DefaultWhyChoiseComponent(IWhyChoiceService _whyChoiceService):ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var item = (await _whyChoiceService.GetAllAsync()).OrderByDescending(x => x.Id).FirstOrDefault();
            return View(item);
        }












    }
}
