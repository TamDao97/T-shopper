using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tshopper.DataAcessLayer;
using Tshopper.Infrastructure;

namespace Tshopper.Api.Extension
{
    public static class ServiceRegister
    {
        public static void Register(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<TshopperContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:TshopperDB"]));
            services.AddControllers();

            #region:register repository
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            #region:register service
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            #endregion
        }
    }
}
