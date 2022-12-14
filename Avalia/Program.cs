using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.ReactiveUI;
using Splat;
using System;

namespace Avalia;
public class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        Bootstrapper.Register(Locator.CurrentMutable, Locator.Current);
        BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
    }

    public static AppBuilder BuildAvaloniaApp()
    {
        return AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace()
                .UseReactiveUI();
    }
}
