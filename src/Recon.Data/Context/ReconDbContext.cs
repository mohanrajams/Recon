using Microsoft.EntityFrameworkCore;
using Recon.Data.EntityConfigurations;
using Recon.Data.Models.Master;

namespace Recon.Data.Context
{
    public class ReconDbContext : DbContext
    {
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        public ReconDbContext()
        {
        }

        public ReconDbContext(DbContextOptions<ReconDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new ProviderEntityConfiguration())
                .ApplyConfiguration(new ProductEntityConfiguration());          
        }              
    }
}
