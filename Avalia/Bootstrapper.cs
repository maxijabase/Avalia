using Avalia.Backend.Interfaces;
using Avalia.Backend.Services;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalia;
public static class Bootstrapper
{
    public static void Register(IMutableDependencyResolver services, IReadonlyDependencyResolver resolver)
    {
        services.RegisterLazySingleton<IEditorManagerService>(() => new EditorManagerService());
    }
}
