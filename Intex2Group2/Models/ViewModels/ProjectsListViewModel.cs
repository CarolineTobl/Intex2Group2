namespace Intex2Group2.Models.ViewModels
{
    public class ProjectsListViewModel
    {
        public IQueryable<Project> Projects { get; set; }

        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();

        public string? CurrentProjectType { get; set; }
    }
}
