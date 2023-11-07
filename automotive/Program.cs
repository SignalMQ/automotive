﻿using Avalonia;
using System;

namespace automotive
{
    internal class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args) => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
        {
            var appBuilder = AppBuilder.Configure<App>();
            appBuilder.UsePlatformDetect();
            appBuilder.WithInterFont();
            appBuilder.LogToTrace();
            appBuilder.UseSkia();
            if (OperatingSystem.IsLinux())
            {
                appBuilder.UseX11();
            }
            return appBuilder;
        }
            
    }
}