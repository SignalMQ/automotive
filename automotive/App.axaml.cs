using automotive.BL.Contexts;
using automotive.BL.Contexts.Interfaces;
using automotive.BL.Models;
using automotive.Factory;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace automotive
{
    public partial class App : Application
    {
        IServiceProvider serviceProvider = GetServices().BuildServiceProvider();

        public static IServiceCollection GetServices()
        {
            IServiceCollection services = new ServiceCollection()
                .AddDbContext<BaseContext>()
                .AddSingleton<IBaseRepository<Transport>, BaseRepository<Transport>>()
                .AddSingleton<IBaseRepository<Car>, BaseRepository<Car>>()
                .AddSingleton<IBaseRepository<Moto>, BaseRepository<Moto>>()
                .AddSingleton<IBaseRepository<Jeep>, BaseRepository<Jeep>>()
                .AddSingleton<IMenuViewFactory, MenuViewFactory>();

            return services;
        }

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = serviceProvider.GetRequiredService<IMenuViewFactory>().Create();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}