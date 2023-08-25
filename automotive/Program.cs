using automotive.Models;
using automotive.Services;
using automotive.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace automotive
{
    public class Program
    {
        private static IServiceCollection services;
        private static IServiceProvider serviceProvider;

        private static void ConfigureServices()
        {
            services = new ServiceCollection()
                .AddSingleton<ICreateService, CreateService>()
                .AddTransient<IRepairService, RepairService>();
        }

        static void Main()
        {
            ConfigureServices();

            serviceProvider = services.BuildServiceProvider();

            var car = serviceProvider?.GetService<Car>();
        }
    }
}
