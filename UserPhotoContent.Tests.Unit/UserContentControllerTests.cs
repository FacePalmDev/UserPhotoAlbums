using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using UserPhotoContent.Api.Controllers;

namespace UserPhotoContent.Tests.Unit
{
    public class UserContentControllerTests
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
            var sut = new UserPhotoContentController(_mockLogger.Object);
            Assert.IsNotNull(sut);
        }

    }
}