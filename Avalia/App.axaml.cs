using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalia.ViewModels;
using Avalia.Views;
using Avalia.Interfaces;
using Splat;
using Avalia.Extensions;

namespace Avalia;
public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            DataContext = GetRequiredService<IMainWindowViewModel>();
            desktop.MainWindow = new MainWindow
            {
                DataContext = DataContext,
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

    private static T GetRequiredService<T>() => Locator.Current.GetRequiredService<T>();
}
