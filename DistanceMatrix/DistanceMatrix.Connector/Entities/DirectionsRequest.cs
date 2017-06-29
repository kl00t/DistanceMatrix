namespace DistanceMatrix.Connector.Entities
{
	public class DirectionsRequest : BaseRequest
	{
		public string origin { get; set; }

		public string destination { get; set; }

		public string mode { get; set; }
	}
}