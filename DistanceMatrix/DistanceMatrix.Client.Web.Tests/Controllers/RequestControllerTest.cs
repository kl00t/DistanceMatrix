using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DistanceMatrix.Client.Web.Controllers;

namespace DistanceMatrix.Client.Web.Tests.Controllers
{
	[TestClass]
	public class RequestControllerTest
	{
		[TestMethod]
		public void RequestControllerIndex()
		{
			// Arrange
			RequestController controller = new RequestController();

			// Act
			ViewResult result = controller.Index() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
		}
	}
}
