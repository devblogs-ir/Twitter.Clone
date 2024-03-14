namespace Twitter.Clone.Locator.Features.LocationService;

public interface IGeoLocator
{
    Task<Location> GetAsync(string ipAddress, CancellationToken cancellationToken = default);
}
