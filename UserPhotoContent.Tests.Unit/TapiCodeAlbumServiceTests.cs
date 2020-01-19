using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using UserPhotoContent.Api.Controllers;
using UserPhotoContent.Common.Contracts.Models;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.Data.Services;
using UserPhotoContent.Domain.Models;
using UserPhotoContent.typicode.Models;
using UserPhotoContent.typicode.Services;

namespace UserPhotoContent.Tests.Unit
{
    public class TapiCodeAlbumServiceTests
    {
        private Mock<RemoteHttpContentService<TypiAlbumModel>> _mockRemoteService;
        private IEnumerable<TypiAlbumModel> _mockResult;

        [SetUp]
        public void Setup()
        {
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
            var sut = new TypiCodeAlbumService(_mockRemoteService.Object);
            Assert.IsNotNull(sut);
        }

        [Test]
        public void ReturnsExpectedData()
        {
            var sut = new TypiCodeAlbumService(_mockRemoteService.Object);

            var result = sut.Get();
            
            Assert.AreEqual(_mockResult, result);
        }

    }
}