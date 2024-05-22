using Microsoft.Extensions.DependencyInjection;

#if NET8_0_OR_GREATER
using Microsoft.Extensions.DependencyInjection.Extensions;
#else
using Microsoft.Extensions.Hosting;
#endif

namespace Quartz;

public static class QuartzServiceCollectionExtensions
{
    public static IServiceCollection AddQuartzHostedService(
        this IServiceCollection services,
        Action<QuartzHostedServiceOptions>? configure = null)
    {
        if (configure != null)
        {
            services.Configure(configure);
        }

#if NET8_0_OR_GREATER
        return services.AddHostedService<QuartzHostedService>();
#else
        return services.AddSingleton<IHostedService, QuartzHostedService>();
#endif
    }

#if NET8_0_OR_GREATER
    public static IServiceCollection AddQuartzHostedService<THostedLifecycleService>(
        this IServiceCollection services,
        Action<QuartzHostedServiceOptions>? configure = null)
        where THostedLifecycleService : class, IQuartzHostedLifecycleService
    {
        services.TryAddSingleton<IQuartzHostedLifecycleService, THostedLifecycleService>();

        return services.AddQuartzHostedService(configure);
    }
#endif
}