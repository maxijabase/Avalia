using Avalonia;
using Avalonia.ReactiveUI;
using Splat;
using System;

namespace Avalia;

internal class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        Bootstrapper.Register(Locator.CurrentMutable, Locator.Current);
        BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .LogToTrace()
            .UseReactiveUI();
}
