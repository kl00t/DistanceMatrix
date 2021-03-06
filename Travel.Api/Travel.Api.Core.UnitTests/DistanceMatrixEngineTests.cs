﻿namespace Travel.Api.Core.UnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Connector.Interfaces;
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
        private IKernel _kernel;

        private static TravelApiEngine _distanceMatrixEngine;

        private Mock<IDistanceMatrixConnector> _mockDistanceMatrixConnector;

        private Mock<IDirectionsConnector> _mockDirectionsConnector;

        private Mock<IRequestHistoryRepository> _mockRequestHistoryRepository;

        private Mock<IElevationConnector> _mockElevationConnector;

        private Mock<ITimezoneConnector> _mockTimezoneConnector;

        private Mock<IGeocodeConnector> _mockGeocodeConnector;

        private Mock<IGeolocationConnector> _mockGeolocationConnector;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestFixtureSetUp]
        public void TextFixtureSetUp()
        {
            _kernel = Startup.Kernel;
			MapperInitialiser.Setup();
		}

        /// <summary>
        /// Called before each test is run.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _mockDistanceMatrixConnector = new Mock<IDistanceMatrixConnector>();
            _mockRequestHistoryRepository = new Mock<IRequestHistoryRepository>();
			_mockDirectionsConnector = new Mock<IDirectionsConnector>();
            _mockElevationConnector = new Mock<IElevationConnector>();
            _mockTimezoneConnector = new Mock<ITimezoneConnector>();
            _mockGeocodeConnector = new Mock<IGeocodeConnector>();
            _mockGeolocationConnector = new Mock<IGeolocationConnector>();

            _distanceMatrixEngine = new TravelApiEngine(
                _mockDistanceMatrixConnector.Object, 
                _mockRequestHistoryRepository.Object,
				_mockDirectionsConnector.Object,
                _mockElevationConnector.Object, 
                _mockTimezoneConnector.Object, 
                _mockGeocodeConnector.Object,
                _mockGeolocationConnector.Object);
        }

        /// <summary>
        /// Verifies the that argument null exception if thrown if connector is null.
        /// </summary>
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void VerifyThatArgumentNullExceptionIfThrownIfConnectorIsNull()
        {
            // ReSharper disable once ObjectCreationAsStatement
            new TravelApiEngine(
				null, 
				new Mock<IRequestHistoryRepository>().Object,
				new Mock<IDirectionsConnector>().Object,
                new Mock<IElevationConnector>().Object, 
                new Mock<ITimezoneConnector>().Object, 
                new Mock<IGeocodeConnector>().Object,
                new Mock<IGeolocationConnector>().Object);
        }

        /// <summary>
        /// Verifies the that argument null exception if thrown repository is null.
        /// </summary>
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void VerifyThatArgumentNullExceptionIfThrownRepositoryIsNull()
        {
            // ReSharper disable once ObjectCreationAsStatement
            new TravelApiEngine(
				new Mock<IDistanceMatrixConnector>().Object, 
				null,
				new Mock<IDirectionsConnector>().Object,
                new Mock<IElevationConnector>().Object, 
                new Mock<ITimezoneConnector>().Object,
                new Mock<IGeocodeConnector>().Object,
                new Mock<IGeolocationConnector>().Object);
        }

        /// <summary>
        /// Verifies the that calculate returns correct response.
        /// </summary>
        [Test]
        public void VerifyThatCalculateReturnsCorrectResponse()
        {
			_mockDistanceMatrixConnector.Setup(x => x.DistanceMatrix(It.IsAny<Connector.Entities.DistanceMatrixRequest>())).Returns(new Connector.Entities.DistanceMatrixResponse());

			var response = _distanceMatrixEngine.DistanceMatrix(new Domain.Models.DistanceMatrixRequest());

			Assert.IsInstanceOf<Domain.Models.DistanceMatrixResponse>(response);
		}

        /// <summary>
        /// Verifies the distance matrix returns correct results.
        /// </summary>
        [Test]
        public void VerifyDistanceMatrixReturnsCorrectResults()
        {
			_mockDistanceMatrixConnector.Setup(x => x.DistanceMatrix(It.IsAny<Connector.Entities.DistanceMatrixRequest>()))
                .Returns(new Connector.Entities.DistanceMatrixResponse
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

            var response = _distanceMatrixEngine.DistanceMatrix(new Domain.Models.DistanceMatrixRequest
			{
				Origins = "Manchester",
				Destinations = "London"
			});

			Assert.AreEqual(Status.Ok, response.Status);
        }

        /// <summary>
        /// Verifies the get request history by identifier is returned.
        /// </summary>
        [Test]
        public void VerifyGetRequestHistoryByIdIsReturned()
        {
            var requestHistoryId = Guid.Parse("827BF1CB-3846-486B-8A34-44954E317EE0");

            var mockRequestHistory = new RequestHistory
            {
                Id = Guid.Parse("827BF1CB-3846-486B-8A34-44954E317EE0"),
                Request = new DistanceMatrixRequest
                {
                    Origins = "Manchester",
                    Destinations = "London",
                    Mode = Mode.Driving,
                    Units = Units.Imperial
                }
            };

            _mockRequestHistoryRepository.Setup(x => x.GetById(It.IsAny<Guid>())).Returns(mockRequestHistory);

            var requestHistory = _distanceMatrixEngine.GetRequestHistory(requestHistoryId);

            Assert.IsNotNull(requestHistory);
            Assert.IsInstanceOf<RequestHistory>(requestHistory);
            Assert.AreEqual("Manchester", requestHistory.Request.Origins);
        }

        /// <summary>
        /// Verifies the request history can be replayed.
        /// </summary>
        [Test]
        public void VerifyRequestHistoryCanBeReplayed()
        {
            var mockRequestHistory = new RequestHistory
            {
                Id = Guid.Parse("E9AB932E-515A-430F-AEEE-3420178B3748"),
                Request = new DistanceMatrixRequest
                {
                    Origins = "Blackpool",
                    Destinations = "Burnley",
                    Mode = Mode.Driving,
                    Units = Units.Imperial
                }
            };

            var requestId = Guid.Parse("E9AB932E-515A-430F-AEEE-3420178B3748");

            _mockRequestHistoryRepository.Setup(x => x.GetById(requestId)).Returns(mockRequestHistory);

            _mockDistanceMatrixConnector.Setup(x => x.DistanceMatrix(It.IsAny<Connector.Entities.DistanceMatrixRequest>()))
                .Returns(new Connector.Entities.DistanceMatrixResponse
                {
                    origin_addresses = new[]
                    {
                        "Blackpool, UK",
                    },
                    destination_addresses = new[]
                    {
                        "Burnley, UK",
                    },
                    rows = new[]
                    {
                        new Row
                        {
                            elements = new[]
                            {
                                new Element
                                {
                                    distance = new Distance
                                    {
                                        text = "50 km",
                                        value = 123
                                    },
                                    duration = new Duration
                                    {
                                        text = "1 hrs 12 mins",
                                        value = 456
                                    },
                                    status = "OK"
                                },
                            }
                        }
                    },
                    status = "OK"
                });

            _mockRequestHistoryRepository.Setup(x => x.InsertRequestHistory(It.IsAny<DistanceMatrixRequest>()));

            var requestHistory = _distanceMatrixEngine.ReplayRequest(requestId);

            Assert.IsNotNull(requestHistory);
            Assert.IsInstanceOf<DistanceMatrixResponse>(requestHistory);
            Assert.AreEqual(Status.Ok, requestHistory.Status);
            Assert.AreEqual("Blackpool, UK", requestHistory.OriginAddresses.First());
        }

        /// <summary>
        /// Verifies the request history is returned.
        /// </summary>
        [Test]
        public void VerifyRequestHistoryIsReturned()
        {
            var mockRequestHistory = new List<RequestHistory>
            {
                new RequestHistory
                {
                    Id = Guid.NewGuid(),
                    Request = new Domain.Models.DistanceMatrixRequest
                    {
                        Origins = "Manchester",
                        Destinations = "London",
                        Mode = Mode.Driving,
                        Units = Units.Metric
                    }
                }
            };

            _mockRequestHistoryRepository.Setup(x => x.GetAll()).Returns(mockRequestHistory);

            var results = _distanceMatrixEngine.GetDistanceMatrixRequestHistory();

            Assert.IsNotNull(results);
            Assert.IsInstanceOf<List<RequestHistory>>(results);
            Assert.AreEqual(1, results.Count);
        }
    }
}