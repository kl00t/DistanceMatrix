namespace DistanceMatrix.Data.UnitTests
{

    using System;
    using System.Collections.Generic;
    using Domain.Enums;
    using Domain.Models;
    using Kernel;
    using Ninject;
    using NUnit.Framework;

    [TestFixture]
    public class MockRequestHistoryRepositoryTests
    {
        private IKernel _kernel;

        private static MockRequestHistoryRepository _requestHistoryRepository;

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
            // setup any mocks here
            _requestHistoryRepository = new MockRequestHistoryRepository();
        }

        [Test]
        public void VerifyGetAllRequestHistoryReturnsResult()
        {
            var result = _requestHistoryRepository.GetAll();
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
            Assert.IsInstanceOf<List<RequestHistory>>(result);
        }

        [Test]
        public void VerifyGetByIdReturnsResult()
        {
            var result = _requestHistoryRepository.GetById(Guid.Parse("CC17BDFA-309A-497A-AF8F-7864BC92664E"));
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<RequestHistory>(result);
        }

        [Test]
        public void VerifyInsertRequestHistory()
        {
            var request = new DistanceMatrixRequest
            {
                Origin = "Paris",
                Destination = "Peckham",
                Mode = Mode.Driving,
                Units = Units.Imperial
            };

            _requestHistoryRepository.InsertRequestHistory(request);
        }

        [Test]
        public void VerifyInsert()
        {
            var request = new RequestHistory
            {
                Request = new DistanceMatrixRequest
                {
                    Origin = "Paris",
                    Destination = "Peckham",
                    Mode = Mode.Driving,
                    Units = Units.Imperial
                }
            };

            var result = _requestHistoryRepository.Insert(request);
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<Guid>(result);
        }

        [Test]
        public void VerifyUpdateRequestHistory()
        {
            var requestHistory = new RequestHistory
            {
                Id = Guid.Parse("CC17BDFA-309A-497A-AF8F-7864BC92664E"),
                Request = new DistanceMatrixRequest
                {
                    Origin = "Burnley",
                    Destination = "Blackpool",
                    Mode = Mode.Driving,
                    Units = Units.Imperial
                }
            };

            _requestHistoryRepository.Update(requestHistory);

            var result = _requestHistoryRepository.GetById(Guid.Parse("CC17BDFA-309A-497A-AF8F-7864BC92664E"));

            Assert.AreEqual("Blackpool", result.Request.Destination);
        }

        [Test]
        public void VerifyDeleteRequestHistory()
        {
            var requestHistoryId = Guid.Parse("CC17BDFA-309A-497A-AF8F-7864BC92664E");

            _requestHistoryRepository.Delete(requestHistoryId);

            Assert.AreEqual(2, _requestHistoryRepository.GetAll().Count);
        }
    }
}