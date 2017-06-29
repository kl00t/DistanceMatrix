using System.Web.Mvc;

namespace DistanceMatrix.Client.Web.Controllers
{
	public class DistanceMatrixController : Controller
    {
        // GET: DistanceMatrix
        public ActionResult Index()
        {
            return View();
        }

		// GET: DistanceMatrix/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Example/Create
		[HttpPost]
		public ActionResult Create(FormCollection collection)
		{
			try
			{
				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		////// GET: Example/Edit/5
		////public ActionResult Edit(int id)
		////{
		////	return View();
		////}

		////// POST: Example/Edit/5
		////[HttpPost]
		////public ActionResult Edit(int id, FormCollection collection)
		////{
		////	try
		////	{
		////		// TODO: Add update logic here

		////		return RedirectToAction("Index");
		////	}
		////	catch
		////	{
		////		return View();
		////	}
		////}

		////// GET: Example/Delete/5
		////public ActionResult Delete(int id)
		////{
		////	return View();
		////}

		////// POST: Example/Delete/5
		////[HttpPost]
		////public ActionResult Delete(int id, FormCollection collection)
		////{
		////	try
		////	{
		////		// TODO: Add delete logic here

		////		return RedirectToAction("Index");
		////	}
		////	catch
		////	{
		////		return View();
		////	}
		////}
	}
}