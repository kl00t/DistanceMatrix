namespace DistanceMatrix.Connector.Entities
{
    public class DirectionsResponse : BaseResponse
    {
		public GeocodedWaypoint[] geocoded_waypoints { get; set; }

		public Route[] routes { get; set; }
	}
}