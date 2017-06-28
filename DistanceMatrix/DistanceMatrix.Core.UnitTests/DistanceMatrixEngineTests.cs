namespace DistanceMatrix.Core.UnitTests
{
    using System;
    using Connector;
    using Connector.Entities;
    using Data;
    using Domain.Enums;
    using Domain.Models;
    using Kernel;
    using Moq;
    using Ninject;
    using NUnit.Framework;
    using Distance = Connector.Entities.Distance;
    using Duration = Connector.Entities.Duration;
    using Element = Connector.Entities.Element;
    using Row = Connector.Entities.Row;

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
        /// The mock request history repository.
        /// </summary>
        private Mock<IRequestHistoryRepository> _mockRequestHistoryRepository;

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
            _mockRequestHistoryRepository = new Mock<IRequestHistoryRepository>();

            _distanceMatrixEngine = new DistanceMatrixEngine(
                _mockDistanceMatrixConnector.Object, 
                _mockRequestHistoryRepository.Object);
        }

        /// <summary>
        /// Verifies the that argument null exception if thrown if connector is null.
        /// </summary>
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void VerifyThatArgumentNullExceptionIfThrownIfConnectorIsNull()
        {
            // ReSharper disable once ObjectCreationAsStatement
            new DistanceMatrixEngine(null, new Mock<IRequestHistoryRepository>().Object);
        }

        /// <summary>
        /// Verifies the that argument null exception if thrown repository is null.
        /// </summary>
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void VerifyThatArgumentNullExceptionIfThrownRepositoryIsNull()
        {
            // ReSharper disable once ObjectCreationAsStatement
            new DistanceMatrixEngine(new Mock<IDistanceMatrixConnector>().Object, null);
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

        /// <summary>
        /// Verifies the distance matrix returns correct results.
        /// </summary>
        [Test]
        public void VerifyDistanceMatrixReturnsCorrectResults()
        {
            _mockDistanceMatrixConnector.Setup(x => x.DistanceMatrix(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(new DistanceMatrix
                {
                    origin_addresses = new[]
                    {
                        "Stockport, UK",
                        "Manchester, UK"
                    },
                    destination_addresses = new[]
                    {
                        "London UK",
                        "Watford, UK"
                    },
                    rows = new []
                    {
                        new Row
                        {
                            elements = new[]
                            {
                                new Element
                                {
                                    distance = new Distance
                                    {
                                        text = "120 km",
                                        value = 123
                                    },
                                    duration = new Duration
                                    {
                                        text = "3 hrs 40 mins",
                                        value = 456
                                    },
                                    status = "OK"
                                },
                            }
                        }
                    },
                    status = "OK"
                });

            var response = _distanceMatrixEngine.DistanceMatrix(new DistanceMatrixRequest
            {
                Origin = "Manchester",
                Destination = "London"
            });

            Assert.AreEqual(Status.Ok, response.Status);
        }
    }
}