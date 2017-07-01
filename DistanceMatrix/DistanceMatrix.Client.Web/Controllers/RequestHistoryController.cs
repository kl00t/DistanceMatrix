using DistanceMatrix.Client.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DistanceMatrix.Client.Web.Controllers
{
    public class RequestHistoryController : Controller
    {
		public ActionResult Index()
		{
			var serviceClient = new GoogleApiService.GoogleApiServiceClient();
			var response = serviceClient.GetDistanceMatrixRequestHistory();
			if (response.IsSuccessful)
			{
				var viewModel = new List<RequestHistoryViewModel>();
				foreach(var rh in response.Response)
				{
					viewModel.Add(new RequestHistoryViewModel
					{
						Id = rh.Id,
						Origins = rh.Request.Origins,
						Destinations = rh.Request.Destinations
					});
				}

				return View("Index", viewModel);
			}

			return View("Error", response.ErrorMessage);
		}

		public ActionResult Delete(Guid id)
		{
			var serviceClient = new GoogleApiService.GoogleApiServiceClient();
			var response = serviceClient.DeleteRequestHistory(id);
			if (response.IsSuccessful)
			{
				return RedirectToAction("Index");
			}

			return View("Error", response.ErrorMessage);
		}

		public ActionResult Replay(Guid id)
		{
			var serviceClient = new GoogleApiService.GoogleApiServiceClient();
			var distanceMatrixResponse = serviceClient.ReplayRequest(id);
			if (distanceMatrixResponse.IsSuccessful)
			{
				var distanceMatrixResults = ControllerHelper.MapResponseToViewModel(distanceMatrixResponse.Response);
				return View("Results", distanceMatrixResults);
			}

			return View("Error", distanceMatrixResponse.ErrorMessage);
		}
	}
}