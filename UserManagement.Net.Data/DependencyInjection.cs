using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UserManagement.Net.Data.Interfaces;
using UserManagement.Net.Data.Repositories;
using UserManagement.Net.Service.Services;
using UserManagement.Net.Service.UseCases;

namespace RegistrationService.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddDbContext<UserManagement.Net.Data.ApplicationDbContext>(options =>
                options.UseInMemoryDatabase("RegistrationDb")); // or use a real database

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRegistrationService, RegisterUser>();
            services.AddScoped<PasswordHasher>();

            return services;
        }
    }
}
