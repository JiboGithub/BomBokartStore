using BomBoKart.Services.ProductAPI.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BomBoKart.Services.ProductAPI.Extensions
{
    public static class StartupExtension
    {

        public static void ConfigureCors(this IServiceCollection services)
        {

        }

        //public static void ConfigureLoggerService(this IServiceCollection services) =>
        //    services.AddScoped<ILoggerManager, LoggerManager>();

        public static void useExtension(this IServiceCollection services, IConfiguration _config) =>
               services.Configure<ReaderModel>(_config.GetSection("ConnectionStrings"));
    }
}
