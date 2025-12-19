using AiTech.WebUI.Services.ProjectServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUI.ViewComponents.UI_Index
{
    public class _DefaultProjectComponent(IProjectService _projectService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await _projectService.GetAllProjectsWithCategoriesAsync();
            return View(items);
        }



    }
}
