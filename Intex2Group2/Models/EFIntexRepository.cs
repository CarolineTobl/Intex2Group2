using Intex2Group2.Data.Scaffolded;

namespace Intex2Group2.Models
{
    public class EFIntexRepository : IIntexRepository
    {
        private ScaffoldedDbContext _context;
        public EFIntexRepository(ScaffoldedDbContext temp) 
        {
            _context = temp;
        }

        public IQueryable<Data.Scaffolded.Product> Products => _context.Products;
    }
}
