using Avalia.Extensions;
using Avalia.Interfaces;
using Avalia.ViewModels;
using Splat;

namespace Avalia;
public static class Bootstrapper
{
    public static void Register(IMutableDependencyResolver services, IReadonlyDependencyResolver resolver)
    {
        services.RegisterLazySingleton<IEditorManagerViewModel>(() => new EditorManagerViewModel());

        services.RegisterLazySingleton<IMenuViewModel>(() => new MenuViewModel(
            resolver.GetRequiredService<IEditorManagerViewModel>()    
        ));

        services.RegisterLazySingleton<IMainWindowViewModel>(() => new MainWindowViewModel(
            resolver.GetRequiredService<IEditorManagerViewModel>(),
            resolver.GetRequiredService<IMenuViewModel>()
        ));
    }
}
