namespace DistanceMatrix.Connector.Entities
{
	public class DistanceMatrixRequest
	{
		public string origins { get; set; }

		public string destinations { get; set; }

		public string mode { get; set; }

		public string key { get; set; }

		public string units { get; set; }
	}
}