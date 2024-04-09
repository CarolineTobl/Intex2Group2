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
            ViewBag.SelectedProjectType = RouteData?.Values["productType"];

            var projectTypes = _waterRepo.Products
                .Select(x => x.Name)
                .Distinct()
                .OrderBy(x => x);

            return View(projectTypes);
        }
    }
}
