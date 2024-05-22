#if NET8_0_OR_GREATER
namespace Quartz;

public interface IQuartzHostedLifecycleService
{
    public Task StartingAsync(CancellationToken cancellationToken);

    public Task StartedAsync(CancellationToken cancellationToken);

    public Task StoppingAsync(CancellationToken cancellationToken);

    public Task StoppedAsync(CancellationToken cancellationToken);
}
#endif