namespace Travel.Api.Domain.Interfaces
{

    using System.Collections.Generic;
    using Models;

    public interface IDirectionsResponse
	{
		List<GeocodedWaypoint> GeocodedWaypoints { get; set; }

		List<Route> Routes { get; set; }
	}
}