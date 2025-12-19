using AiTech.WebUI.Services.OurTeamServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AiTech.WebUI.ViewComponents.UI_Index
{
    public class _DefaultOurTeamComponnet(IOurTeamService _ourTeamService):ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _ourTeamService.GetAllAsync();
            return View(values);

        }






    }
}
