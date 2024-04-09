using Microsoft.AspNetCore.Mvc;
using Intex2Group2.Models;

namespace Intex2Group2.Components
{
    public class ProjectTypesViewComponent :ViewComponent
    {
        private IIntexRepository _waterRepo;

        //Constructor
        public ProjectTypesViewComponent(IIntexRepository temp) 
        {
            _waterRepo = temp;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedProjectType = RouteData?.Values["projectType"];

            var projectTypes = _waterRepo.Projects
                .Select(x => x.ProjectType)
                .Distinct()
                .OrderBy(x => x);

            return View(projectTypes);
        }
    }
}
