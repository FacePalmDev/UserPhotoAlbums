using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using TechTalk.SpecFlow;
using UserPhotoContent.Api.Controllers;
using UserPhotoContent.Interfaces.Models;
using UserPhotoContent.Interfaces.Services;

namespace UserPhotoContent.Tests.Integration
{
    [Binding]
    public class RetrievingUserPhotoContentSteps
    {
        private UserPhotoContentController _userPhotoContentController;
        private IActionResult _response;

        [Given(@"The user does not have any content")]
        public void GivenTheUserDoesNotHaveAnyContent()
        {
            var mockLogger = new Mock<ILogger<UserPhotoContentController>>();
            var mockService = new Mock<IUserContentService>();

            mockService.Setup(s => s.Get(It.IsAny<int>())).Returns(new List<IDomainModel>());

            _userPhotoContentController = new UserPhotoContentController(mockLogger.Object, mockService.Object);
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

        [When(@"the data is requested (.*) format")]
        public void WhenTheDataIsRequestedFormat(string p0)
        {
            Assert.Fail();
        }

        [When(@"the data is requested in ""(.*)"" format")]
        public void WhenTheDataIsRequestedInFormat(string format)
        {
            Assert.Fail();
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
