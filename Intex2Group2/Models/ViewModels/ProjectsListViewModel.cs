using Intex2Group2.Data.Scaffolded;

namespace Intex2Group2.Models.ViewModels
{
    public class ProjectsListViewModel
    {
        public IQueryable<Data.Scaffolded.Product> Products { get; set; }

        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();

        public string? CurrentProjectType { get; set; }
    }
}
