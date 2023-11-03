using automotive.Contexts;
using automotive.Contexts.Interfaces;
using automotive.Services;
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
                .AddDbContext<BaseContext>()
                .AddSingleton<IBaseRepository, BaseRepository>()
                .AddSingleton<Sample>();
        }

        static void Main()
        {
            ConfigureServices();

            serviceProvider = services.BuildServiceProvider();

            IBaseRepository baseRepository = new BaseRepository();

            var sample = serviceProvider.GetRequiredService<Sample>();

            baseRepository.AddAsync(sample.SampleData());
            baseRepository.SaveChanges();
        }
    }
}
