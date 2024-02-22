namespace Twitter.Clone.Locator.Features.LocationService;

public class GeoLocatorApi(IMapper mapper, IOptions<LocationServiceAppSettings> locationServiceOptions) : IGeoLocator
{
    public const string LocatorName = "GeoLocatorAPI";

    public async Task<Location> GetAsync(string ipAddress, CancellationToken cancellationToken = default)
    {
        var httpClient = new HttpClient();
        var uri = new Uri($"https://api.ipgeolocation.io/ipgeo?apiKey={locationServiceOptions.Value.IPGeoApiKey}&ip={ipAddress}");

        var locatorResponse = await httpClient.GetFromJsonAsync<GeoLocationResponse>(uri, cancellationToken);

        if (locatorResponse is null)
        {
            throw new UnableToConnectLocatorApiException();
        }

        return mapper.Map<Location>(locatorResponse);
    }
}