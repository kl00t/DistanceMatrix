namespace DistanceMatrix.Core.UnitTests
{

    using Domain.Models;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class DistanceMatrixEngineTests
    {
        private static DistanceMatrixEngine _distanceMatrixEngine;

        private Mock<IDistanceMatrixConnector> _mockDistanceMatrixConnector;

        /// <summary>
        /// Called before each test is run.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _mockDistanceMatrixConnector = new Mock<IDistanceMatrixConnector>();

            _distanceMatrixEngine = new DistanceMatrixEngine(_mockDistanceMatrixConnector.Object);
        }

        [Test]
        public void VerifyThatEngineReturnsCorrectResponse()
        {
            _mockDistanceMatrixConnector.Setup(x => x.Calculate(It.IsAny<DistanceMatrixRequest>())).Returns(new DistanceMatrixResponse());

            var response = _distanceMatrixEngine.Calculate(new DistanceMatrixRequest());

            Assert.IsInstanceOf<DistanceMatrixResponse>(response);
        }
    }
}