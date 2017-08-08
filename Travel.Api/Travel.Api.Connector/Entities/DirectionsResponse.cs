namespace Travel.Api.Connector.Entities
{
    public class DirectionsResponse : BaseResponse
    {
		public GeocodedWaypoint[] geocoded_waypoints { get; set; }

		public Route[] routes { get; set; }
	}
}