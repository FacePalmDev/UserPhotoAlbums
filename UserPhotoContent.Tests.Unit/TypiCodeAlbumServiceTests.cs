using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.Common.Mapping;
using UserPhotoContent.Data.Models;
using UserPhotoContent.Data.Services;
using UserPhotoContent.typicode.Models;
using UserPhotoContent.typicode.Services;

namespace UserPhotoContent.Tests.Unit
{
    public class TypiCodeAlbumServiceTests
    {
        private Mock<RemoteHttpContentService<TypiAlbumModel>> _mockRemoteService;
        private IEnumerable<TypiAlbumModel> _mockResult;
        private IMapperService _mapperService;

        [SetUp]
        public void Setup()
        {
            // Todo: Consider mocking if time permits.
            // Could use Dependency Injection in test perhaps. Maybe overkill.
            _mapperService = new MapperService();

            _mockResult = new List<TypiAlbumModel>()
            {
                new TypiAlbumModel()
                {
                    Id = 1,
                    Title = "Some Album",
                    UserId = 123
                }
            };

            _mockRemoteService = new Mock<RemoteHttpContentService<TypiAlbumModel>>();
            
            _mockRemoteService.Setup(x => 
                    x.Get(It.IsAny<Uri>()))
                .Returns(Task.Run(() => _mockResult));
        }

        [Test]
        public void CanInstantiate()
        {
            var sut = new TypiCodeAlbumService(_mapperService, _mockRemoteService.Object);
            Assert.IsNotNull(sut);
        }

        [Test]
        public void ReturnsExpectedData()
        {
            var sut = new TypiCodeAlbumService(_mapperService, _mockRemoteService.Object);

            var actual = sut.Get().ToList();
            var expected = 
                _mapperService.Map<IEnumerable<AlbumDtoModel>>(_mockResult)
                .ToList();

            var albumDtoModels = actual.ToList();
            Assert.AreEqual(expected.Count(), albumDtoModels.Count());

            for (var index = 0; index < albumDtoModels.Count; index++)
            {
                var expectedItem = albumDtoModels[index];
                var actualItem = actual[index];
                Assert.AreEqual(expectedItem, actualItem);
            }
        }

    }
}