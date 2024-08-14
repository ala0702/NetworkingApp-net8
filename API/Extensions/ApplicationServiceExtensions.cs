using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    // static -> we dont need to create new instance of a class
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddControllers();
        services.AddDbContext<DataContext>(opt =>
        {
            opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
        }
        );
        services.AddCors();
        services.AddScoped<ITokenService, TokenService>();// each time that it is requested so each time that user is loggin in

        return services;
    }

}