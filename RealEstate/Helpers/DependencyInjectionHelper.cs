using DataAccess.Implementations;
using DataAccess.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using RealEstate.Models;
using Services.Implementations;
using Services.Interfaces;

namespace Helpers
{
    public static class DependencyInjectionHelper
    {
        public static void InjectRepositories(IServiceCollection services)
        {
            services.AddTransient<IUserRepository, MockUserRepository>();
            services.AddTransient<IRepository<Estate>, MockEstateRepository>();
        }

        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
        }
    }
}
