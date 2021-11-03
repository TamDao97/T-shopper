using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tshopper.Business;
using Tshopper.DataAcessLayer;
using Tshopper.Infrastructure;

namespace Tshopper.Api
{
    public static class ServiceRegister
    {
        public static DbContextOptions _contextOptions;
        public static void Register(this IServiceCollection services, IConfiguration Configuration)
        {
            _contextOptions = new DbContextOptionsBuilder().UseSqlServer(Configuration["ConnectionString:TshopperDB"]).Options;
            services.AddDbContext<TshopperContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:TshopperDB"]));
            services.AddControllers();

            #region:register repository
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            #endregion

            #region:register business
            services.AddScoped<IProductBusiness, ProductBusiness>();
            #endregion
        }
    }
}
