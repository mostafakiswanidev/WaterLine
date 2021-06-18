using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WATERLINE.DataAccess.Helper;
using WATERLINE.Services.Repositories.Implemntations;
using WATERLINE.Services.Repositories.Interfaces;

namespace WATERLINE.Services.Helper
{
    public static class IServiceCollectionExtension
    {
        public static IConfiguration Configuration { get; set; }

        public static IServiceCollection AddServiceLibrary(this IServiceCollection services)
        {

            services.AddServiceRepositories();
            services.AddDataAccessLibrary();
            return services;
        }

        private static IServiceCollection AddServiceRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRolesRepository, RolesRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            
            return services;
        }
    }
}
