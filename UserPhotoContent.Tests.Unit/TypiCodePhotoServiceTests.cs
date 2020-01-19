using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using UserPhotoContent.Common.Mapping;
using UserPhotoContent.Data.Models;
using UserPhotoContent.Data.Services;
using UserPhotoContent.typicode.Models;
using UserPhotoContent.typicode.Services;

namespace UserPhotoContent.Tests.Unit
{
    public class TypiCodePhotoServiceTests
    {
        private Mock<RemoteHttpContentService<TypiPhotoModel>> _mockRemoteService;
        private IEnumerable<TypiPhotoModel> _mockResult;
        private MapperService _mapperService;

        [SetUp]
        public void Setup()
        {
            // Todo: Consider mocking if time permits.
            _mapperService = new MapperService();

            _mockResult = new List<TypiPhotoModel>()
            {
                new TypiPhotoModel()
                {
                    Id = 1,
                    Title = "Some Album",
                    ThumbnailUrl = "https://via.placeholder.com/600/92c952",
                    AlbumId = 1,
                    Url = "https://via.placeholder.com/150/92c952"
                }
            };

            _mockRemoteService = new Mock<RemoteHttpContentService<TypiPhotoModel>>();

            _mockRemoteService.Setup(x =>
                    x.Get(It.IsAny<Uri>()))
                .Returns(Task.Run(() => _mockResult));
        }

        [Test]
        public void CanInstantiate()
        {
            var sut = new TypiCodePhotoService(_mapperService, _mockRemoteService.Object);
            Assert.IsNotNull(sut);
        }

        [Test]
        public void ReturnsExpectedData()
        {
            var sut =
                new TypiCodePhotoService(_mapperService, _mockRemoteService.Object);

            var actual = sut.Get().ToList();

            var expected =
                _mapperService.Map<IEnumerable<PhotoDtoModel>>(_mockResult)
                    .ToList();

            Assert.AreEqual(expected.Count(), actual.Count());

            for (var index = 0; index < actual.Count; index++)
            {
                var expectedItem = expected[index];
                var actualItem = actual[index];
                Assert.AreEqual(expectedItem, actualItem);
            }
        }

    }

}
