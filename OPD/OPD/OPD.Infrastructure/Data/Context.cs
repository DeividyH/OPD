using Microsoft.EntityFrameworkCore;
using OPD.Domain.Entities.Custumers;
using OPD.Domain.Entities.Products;

namespace OPD.Infrastructure.Data
{
    public class Context : DbContext
    {
        public Context()
        {

        }

        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Custumer> Custumers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
