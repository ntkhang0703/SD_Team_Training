
using API._Repositories;
using API._Services.Interfaces;
using API._Services.Services;

namespace API.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //thêm Repossitoryaccessor
            services.AddScoped<IRepositoryAccessor, RepositoryAccessor>();

            // add services
            services.AddScoped<IShiftDataMaintenanceService,ShiftDataMaintenanceService>();
            
        }
    }
}