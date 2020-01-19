using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using TechTalk.SpecFlow;
using UserPhotoContent.Api.Controllers;
using UserPhotoContent.Common.Contracts.Models;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.Domain.Models;

namespace UserPhotoContent.Tests.Integration
{
    [Binding]
    public class RetrievingUserPhotoContentSteps
    {
        private PhotoAlbumsController _userPhotoContentController;
        private IActionResult _response;

        [Given(@"The user does not have any content")]
        public void GivenTheUserDoesNotHaveAnyContent()
        {
            var mockLogger = new Mock<ILogger<PhotoAlbumsController>>();
            var mockService = new Mock<IUserContentService<PhotoAlbumModel>>();

            mockService.Setup(s => s.Get(It.IsAny<int>())).Returns(new List<PhotoAlbumModel>());

            _userPhotoContentController = new PhotoAlbumsController(mockLogger.Object, mockService.Object);
        }

        [Given(@"The user has (.*) and (.*)")]
        public void GivenTheUserHasAnd(int noPhotos, int noAlbums)
        {
            Assert.Fail();
        }

        [When(@"the data is requested")]
        public void WhenTheDataIsRequested()
        {
            _response = _userPhotoContentController.Get(1);
        }


        [Then(@"the resulting HTTP Status code should be (.*)")]
        public void ThenTheResultingHttpStatusCodeShouldBe(int p0)
        {
            var expected = typeof(NotFoundResult);
            var actual = _response.GetType();

            Assert.AreEqual(expected, actual);
        }

        [Then(@"the result should contain (.*) photos")]
        public void ThenTheResultShouldContainPhotos(int expectedPhotoCount)
        {
            Assert.Fail();
        }

        [Then(@"the result should contain (.*) albums")]
        public void ThenTheResultShouldContainAlbums(int expectedAlbumCount)
        {
            Assert.Fail();
        }

        [Then(@"The content should be formatted as (.*)")]
        public void ThenTheContentShouldBeFormattedAs(string expectedFormat)
        {
            Assert.Fail();
        }
    }
}
