using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using UserPhotoContent.Api.Controllers;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.Domain.Models;

namespace UserPhotoContent.Tests.Unit
{
    public class PhotoAlbumsControllerTests
    {
        private Mock<ILogger<PhotoAlbumsController>> _mockLogger;

        [SetUp]
        public void Setup()
        { 
            _mockLogger = new Mock<ILogger<PhotoAlbumsController>>();
        }

        [Test]
        public void CanInstantiate()
        {
            var sut = new PhotoAlbumsController(_mockLogger.Object, 
                new Mock<IUserContentService<PhotoAlbumModel>>().Object);

            Assert.IsNotNull(sut);
        }

        [Test]
        public void GracefullyHandlesNoUserContentWith404Response()
        {
            var mockContentService = new Mock<IUserContentService<PhotoAlbumModel>>();

            var sut = new PhotoAlbumsController(_mockLogger.Object,
                mockContentService.Object);

            var actual = sut.Get(1).GetType();
            var expected = typeof(NotFoundResult);

            Assert.AreEqual(expected, actual);
        }

    }
}