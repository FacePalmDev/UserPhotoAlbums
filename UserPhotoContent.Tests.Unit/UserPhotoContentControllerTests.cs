using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using UserPhotoContent.Api.Controllers;
using UserPhotoContent.Api.Services;

namespace UserPhotoContent.Tests.Unit.UserContent
{
    public class UserPhotoContentControllerTests
    {
        private Mock<ILogger<UserPhotoContentController>> _mockLogger;

        [SetUp]
        public void Setup()
        { 
            _mockLogger = new Mock<ILogger<UserPhotoContentController>>();
        }

        [Test]
        public void CanInstantiate()
        {
            var sut = new UserPhotoContentController(_mockLogger.Object, 
                new Mock<IContentService>().Object);

            Assert.IsNotNull(sut);
        }

        [Test]
        public void GracefullyHandlesNoUserContentWith404Response()
        {
            var mockContentService = new Mock<IContentService>();

            var sut = new UserPhotoContentController(_mockLogger.Object,
                mockContentService.Object);

            var actual = sut.Get(1).GetType();
            var expected = typeof(NotFoundResult);

            Assert.AreEqual(expected, actual);
        }

    }
}