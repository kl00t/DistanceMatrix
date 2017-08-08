namespace Travel.Api.Client.Web.Models
{

    using System;

    public class RequestHistoryViewModel
	{
		public Guid Id { get; set; }

		public string Origins { get; set; }

		public string Destinations { get; set; }
	}
}