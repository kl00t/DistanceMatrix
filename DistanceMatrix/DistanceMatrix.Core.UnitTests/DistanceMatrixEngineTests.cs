namespace DistanceMatrix.Core.UnitTests
{

    using System;
    using Connector;
    using Connector.Entities;
    using Domain.Models;
    using Moq;
    using Ninject;
    using NUnit.Framework;

    [TestFixture]
    public class DistanceMatrixEngineTests
    {
        /// <summary>
        /// The kernel.
        /// </summary>
        private IKernel _kernel;

        /// <summary>
        /// The distance matrix engine.
        /// </summary>
        private static DistanceMatrixEngine _distanceMatrixEngine;

        /// <summary>
        /// The mock distance matrix connector.
        /// </summary>
        private Mock<IDistanceMatrixConnector> _mockDistanceMatrixConnector;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestFixtureSetUp]
        public void TextFixtureSetUp()
        {
            _kernel = Startup.Kernel;
        }

        /// <summary>
        /// Called before each test is run.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _mockDistanceMatrixConnector = new Mock<IDistanceMatrixConnector>();

            _distanceMatrixEngine = new DistanceMatrixEngine(_mockDistanceMatrixConnector.Object);
        }

        /// <summary>
        /// Verifies the that argument null exception if thrown if connector is null.
        /// </summary>
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void VerifyThatArgumentNullExceptionIfThrownIfConnectorIsNull()
        {
            // ReSharper disable once ObjectCreationAsStatement
            new DistanceMatrixEngine(null);
        }

        /// <summary>
        /// Verifies the that calculate returns correct response.
        /// </summary>
        [Test]
        public void VerifyThatCalculateReturnsCorrectResponse()
        {
            _mockDistanceMatrixConnector.Setup(x => x.DistanceMatrix(It.IsAny<string>(), It.IsAny<string>())).Returns(new DistanceMatrix());

            var response = _distanceMatrixEngine.DistanceMatrix(new DistanceMatrixRequest());

            Assert.IsInstanceOf<DistanceMatrixResponse>(response);
        }
    }
}