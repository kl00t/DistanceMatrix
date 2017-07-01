using DistanceMatrix.Client.Web.Models;
using DistanceMatrix.Core.Helpers;
using DistanceMatrix.Domain.Enums;
using DistanceMatrix.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DistanceMatrix.Client.Web.Controllers
{
	public class DistanceMatrixController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Index(DistanceMatrixRequest distanceMatrixRequest)
		{
			var serviceClient = new GoogleApiService.GoogleApiServiceClient();
			var distanceMatrixResponse = serviceClient.DistanceMatrix(distanceMatrixRequest);
			if (distanceMatrixResponse.IsSuccessful)
			{
				if (distanceMatrixResponse.Response.Status == Status.Ok)
				{
					var distanceMatrixResults = ControllerHelper.MapResponseToViewModel(distanceMatrixResponse.Response);
					return View("Results", distanceMatrixResults);
				}
			}

			return View("Error", distanceMatrixResponse.ErrorMessage);
		}

		public ActionResult Results(DistanceMatrixResultsViewModel distanceMatrixResults)
		{
			return View("Results", distanceMatrixResults);
		}
	}
}