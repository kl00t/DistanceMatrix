using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DistanceMatrix.Client.Web.Controllers;

namespace DistanceMatrix.Client.Web.Tests.Controllers
{
	[TestClass]
	public class HomeControllerTest
	{
		[TestMethod]
		public void HomeControllerIndex()
		{
			// Arrange
			HomeController controller = new HomeController();

			// Act
			ViewResult result = controller.Index() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
		}
	}
}
