namespace Travel.Api.Client.Web.Models
{

    using System.Collections.Generic;

    public class DistanceMatrixResultsViewModel
	{
		public string Origins { get; set; }

		public string Destinations { get; set; }

		public List<string> Results { get; set; }
	}
}