using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Recon.Data.Context;

namespace Recon.Data.Extensions
{
    public static class DbExtensions
    {
        public static void EnsureDbExists(this IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            using var dbContext = scope.ServiceProvider.GetRequiredService<ReconDbContext>();
            dbContext.Database.Migrate();
        }       
    }
}
