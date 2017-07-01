

using DistanceMatrix.Client.Web.Models;
using DistanceMatrix.Core.Helpers;
using DistanceMatrix.Domain.Enums;
using DistanceMatrix.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace DistanceMatrix.Client.Web.Controllers
{
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