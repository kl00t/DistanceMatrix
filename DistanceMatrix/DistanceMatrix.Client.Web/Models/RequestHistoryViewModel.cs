using System;

namespace DistanceMatrix.Client.Web.Models
{
	public class RequestHistoryViewModel
	{
		public Guid Id { get; set; }

		public string Origins { get; set; }

		public string Destinations { get; set; }
	}
}