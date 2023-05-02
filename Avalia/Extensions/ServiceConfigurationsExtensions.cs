using Splat;
using System;

namespace Avalia.Extensions;
public static class ServiceConfigurationsExtensions
{
    public static TService GetRequiredService<TService>(this IReadonlyDependencyResolver resolver)
    {
        var service = resolver.GetService<TService>() ?? throw new InvalidOperationException($"Failed to resolve object of type {typeof(TService)}");
        return service; // return instance if not null
    }
}
