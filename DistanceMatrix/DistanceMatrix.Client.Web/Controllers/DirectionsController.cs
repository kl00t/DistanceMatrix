using System.Web.Mvc;

namespace DistanceMatrix.Client.Web.Controllers
{
	public class DirectionsController : Controller
    {
        // GET: Directions
        public ActionResult Index()
        {
            return View();
        }

		// GET: Directions/Create
		public ActionResult Create()
		{
			return View();
		}
	}
}