using Microsoft.EntityFrameworkCore;
using Recon.Data.EntityConfigurations;
using Recon.Data.Models.Master;

namespace Recon.Data.Context
{
    public class ReconDbContext : DbContext
    {
        public virtual DbSet<LookupCategory> LookupCategories { get; set; }
        public virtual DbSet<LookUp> LookUps { get; set; }

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
                .ApplyConfiguration(new LookUpCategoryEntityConfiguration())
                .ApplyConfiguration(new LookUpEntityConfiguration());


            AddLookUpCategories(modelBuilder);
        }
        
        private static void AddLookUpCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LookupCategory>().HasData(
                new LookupCategory { Id = 1, Name = "Provider" },
                new LookupCategory { Id = 2, Name = "Product" });
        }
    }
}
