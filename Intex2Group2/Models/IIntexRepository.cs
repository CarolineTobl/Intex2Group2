using Intex2Group2.Data.Scaffolded;

namespace Intex2Group2.Models
{
    public interface IIntexRepository
    {
        public IQueryable<Data.Scaffolded.Product> Products { get; }

    }
}
