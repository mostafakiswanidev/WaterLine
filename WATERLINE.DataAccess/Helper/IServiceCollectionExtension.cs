using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WATERLINE.Context;
using WATERLINE.DataAccess.Repositories.Implemntations;
using WATERLINE.DataAccess.Repositories.Interfaces;
using WATERLINE.Settings;

namespace WATERLINE.DataAccess.Helper
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddDataAccessLibrary(this IServiceCollection services)
        {
            services.AddDataAccessRepositories();
            return services;
        }

        private static IServiceCollection AddDataAccessRepositories(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>(options => options.UseSqlServer(Config.LocalConnectionString), ServiceLifetime.Transient);
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            return services;
        }
    }
}
