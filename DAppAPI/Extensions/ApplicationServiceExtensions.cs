using API.Services;
using DAppAPI.Data;
using DAppAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAppAPI.Extensions
{
    public static class  ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            services.AddCors();
            services.AddSingleton<ITokenService, TokenService>();

            return services;
        }
    }
}
