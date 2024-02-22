﻿namespace Twitter.Clone.Locator.Features.LocationService;

public record class LocationResponse(
       double Latitude,
       double Longitude,
       string ContinentName,
       string CountryName,
       string CountryCode,
       string State,
       string City,
       string CallingCode);
