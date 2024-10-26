using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Recon.Data.Context;
using Recon.Data.Helpers;

namespace Recon.Data
{
    public class ReconDbDesignTimeDbContextFactory : IDesignTimeDbContextFactory<ReconDbContext>
    {
        public ReconDbContext CreateDbContext(string[] args)
        {            
            var optionsBuilder = new DbContextOptionsBuilder<ReconDbContext>();

            optionsBuilder.UseSqlite(DbHelper.GetSqliteConnectionString());

            return new ReconDbContext(optionsBuilder.Options);
        }
    }
}
