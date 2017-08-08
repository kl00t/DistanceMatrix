namespace Travel.Api.Client.Web.Controllers
{

    using System.Collections.Generic;
    using System.Linq;
    using Core.Helpers;
    using Domain.Enums;
    using Domain.Models;
    using Models;

    public static class ControllerHelper
	{
		public static DistanceMatrixResultsViewModel MapResponseToViewModel(DistanceMatrixResponse distanceMatrixResponse)
		{
			var results = new List<string>();
			foreach (var element in distanceMatrixResponse.Rows.SelectMany(row => row.Elements.Where(element => element.Status == ElementStatus.Ok)))
			{
				results.Add(string.Format("Distance: {0} | Duration: {1}", element.Distance.Text, element.Duration.Text));
			}

			var distanceMatrixResults = new DistanceMatrixResultsViewModel
			{
				Origins = StringHelper.ConvertListToString(" | ", distanceMatrixResponse.OriginAddresses),
				Destinations = StringHelper.ConvertListToString(" | ", distanceMatrixResponse.DestinationAddresses),
				Results = results
			};

			return distanceMatrixResults;
		}
	}
}