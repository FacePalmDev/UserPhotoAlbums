using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using TechTalk.SpecFlow;
using UserPhotoContent.Api.Controllers;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.Common.Mapping;
using UserPhotoContent.Data.Services;
using UserPhotoContent.Domain.Models;
using UserPhotoContent.Domain.Services;
using UserPhotoContent.typicode.Models;
using UserPhotoContent.typicode.Services;

namespace UserPhotoContent.Tests.Integration
{
    [Binding]
    public class RetrievingUserPhotoContentSteps
    {
        private PhotoAlbumsController _userPhotoContentController;
        private IActionResult _response;
        private int _noPhotos;
        private int _noAlbums;
        private Mock<RemoteHttpContentService<TypiAlbumModel>> _remoteAlbumService;
        private Mock<RemoteHttpContentService<TypiPhotoModel>> _remotePhotoService;

        [Given(@"The user does not have any content")]
        public void GivenTheUserDoesNotHaveAnyContent()
        {
            _remoteAlbumService = new Mock<RemoteHttpContentService<TypiAlbumModel>>();
            _remotePhotoService = new Mock<RemoteHttpContentService<TypiPhotoModel>>();
        }

        [Given(@"The user has (.*) and (.*)")]
        public void GivenTheUserHasAnd(int noPhotos, int noAlbums)
        {
            _remoteAlbumService = new Mock<RemoteHttpContentService<TypiAlbumModel>>();
            _remotePhotoService = new Mock<RemoteHttpContentService<TypiPhotoModel>>();

            _remoteAlbumService.Setup(x =>
                x.Get(It.IsAny<Uri>())).ReturnsAsync(() =>
            {
                var result = new List<TypiAlbumModel>();

                for (var index = 0; index < noAlbums; index++)
                {
                    result.Add(new TypiAlbumModel()
                    {
                        Id = 1,
                        UserId = 1,
                    });
                }

                return result;

            });

            _remotePhotoService.Setup(x =>
                x.Get(It.IsAny<Uri>())).ReturnsAsync(() =>
            {
                var result = new List<TypiPhotoModel>();

                for (var index = 0; index < noPhotos; index++)
                {
                    result.Add(new TypiPhotoModel()
                    {
                        AlbumId = 1
                    });
                }

                return result;

            });


            _noPhotos = noPhotos;
            _noAlbums = noAlbums;
        }

        [When(@"the data is requested")]
        public void WhenTheDataIsRequested()
        {
            var mapperService = new MapperService();

            var typiAlbumService = new TypiCodeAlbumService(mapperService, _remoteAlbumService.Object);
            var typiPhotoService = new TypiCodePhotoService(mapperService, _remotePhotoService.Object);

            var photoAlbumService = new PhotoAlbumsService(
                typiAlbumService,
                typiPhotoService,
                mapperService);

            var mockLogger = new Mock<ILogger<PhotoAlbumsController>>();

            _userPhotoContentController = new PhotoAlbumsController(mockLogger.Object, photoAlbumService);
            _response = _userPhotoContentController.Get(1);
        }



        [Then(@"the resulting HTTP Status code should be (.*)")]
        public void ThenTheResultingHTTPStatusCodeShouldBe(string expectedStatusCode)
        {
            var actual = _response.GetType();

            var expected = expectedStatusCode switch
            {
                "404" => typeof(NotFoundResult),
                "200" => typeof(JsonResult),
                _ => null
            };
        }


        [Then(@"the result should contain (.*) photos")]
        public void ThenTheResultShouldContainPhotos(int expectedPhotoCount)
        {
            var result = _response as JsonResult;
            var model = result?.Value as IEnumerable<PhotoAlbumModel>;

            var photoCount = model?.Sum(item => item.Photos.Count());

            Assert.AreEqual(expectedPhotoCount, photoCount);
        }

        [Then(@"the result should contain (.*) albums")]
        public void ThenTheResultShouldContainAlbums(int expectedAlbumCount)
        {
            var result = _response as JsonResult;
            var model = result?.Value as IEnumerable<PhotoAlbumModel>;

            Assert.AreEqual(expectedAlbumCount, model?.Count());
        }


    }
}
