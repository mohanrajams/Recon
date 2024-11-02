using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Recon.Data.Context;
using Recon.Data.Helpers;
using Recon.Data.Repositories;

namespace Recon.Data.Extensions
{
    public static class ServiceCollectionExternsion
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            services.AddDbContext<ReconDbContext>(opt => opt.UseSqlite(DbHelper.GetSqliteConnectionString()));
            services.AddScoped(typeof(IMasterRepository<>), typeof(MasterRepository<>));
            return services;
        }
    }
}
