namespace DistanceMatrix.Connector.Entities
{
	public class GeocodedWaypoint
	{
		public string geocoder_status { get; set; }

		public string partial_match { get; set; }

		public string place_id { get; set; }

		public string[] types { get; set; }
	}
}