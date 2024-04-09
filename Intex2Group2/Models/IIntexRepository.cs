namespace Intex2Group2.Models
{
    public interface IIntexRepository
    {
        public IQueryable<Project> Projects { get; }

    }
}
