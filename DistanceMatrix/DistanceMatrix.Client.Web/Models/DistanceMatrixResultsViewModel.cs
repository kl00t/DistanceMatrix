using System.Collections.Generic;

namespace DistanceMatrix.Client.Web.Models
{
	public class DistanceMatrixResultsViewModel
	{
		public string Origins { get; set; }

		public string Destinations { get; set; }

		public List<string> Results { get; set; }
	}
}