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
			var controller = new HomeController();

			// Act
			var result = controller.Index() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
		}
	}
}
