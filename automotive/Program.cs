using automotive.Services;
using automotive.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

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
                .AddTransient<IRepairService, RepairService>()
                .AddSingleton<Sample>();
        }

        static void Main()
        {
            ConfigureServices();

            serviceProvider = services.BuildServiceProvider();

            var sample = serviceProvider.GetRequiredService<Sample>();

            string json = JsonConvert.SerializeObject(sample.SampleData(), Formatting.Indented);

            Console.WriteLine(json);
        }
    }
}
