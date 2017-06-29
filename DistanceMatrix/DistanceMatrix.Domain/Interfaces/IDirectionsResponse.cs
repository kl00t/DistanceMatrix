namespace DistanceMatrix.Domain.Interfaces
{
	using Models;
	using System.Collections.Generic;

	public interface IDirectionsResponse
	{
		List<GeocodedWaypoint> GeocodedWaypoints { get; set; }

		List<Route> Routes { get; set; }
	}
}