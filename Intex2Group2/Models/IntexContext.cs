using Microsoft.EntityFrameworkCore;

namespace Intex2Group2.Models
{
    public class IntexContext : DbContext
    {
        public IntexContext (DbContextOptions<IntexContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
    }
}
