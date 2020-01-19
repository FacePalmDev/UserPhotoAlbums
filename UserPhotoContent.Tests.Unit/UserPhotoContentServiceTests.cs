using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using UserPhotoContent.Common.Contracts.Models;
using UserPhotoContent.Common.Contracts.Services;
using UserPhotoContent.Common.Mapping;
using UserPhotoContent.Data.Models;
using UserPhotoContent.Domain;

namespace UserPhotoContent.Tests.Unit
{
    public class UserPhotoContentServiceTests
    {
        private Mock<IUserService<AlbumDtoModel>> _mockAlbumService;
        private Mock<IUserService<PhotoDtoModel>> _mockPhotoService;
        private MapperService _mapperService;

        [SetUp]
        public void Setup()
        {
            // todo: this should really be mocked. 
            _mapperService = new MapperService();
            SetupMockServices();
        }

        [Test]
        public void CanInstantiate()
        {
            var sut = new PhotoAlbumsService(
                _mockAlbumService.Object,
                _mockPhotoService.Object,
                _mapperService);

            Assert.IsNotNull(sut);
        }

        [Test]
        public void ShouldReturnTheExpectedNumberOfAlbums()
        {
            var sut = new PhotoAlbumsService(
                _mockAlbumService.Object,
                _mockPhotoService.Object,
                _mapperService);

            var actual = sut.Get(1);

            Assert.AreEqual(1, actual.Count());
        }

        [Test]
        public void ShouldReturnTheExpectedNumberOfPhotos()
        {
            var sut = new PhotoAlbumsService(
                _mockAlbumService.Object,
                _mockPhotoService.Object,
                _mapperService);

            var albums = sut.Get(1).First();
            var actual = albums.Photos.Count();

            Assert.AreEqual(2, actual);
        }


        private void SetupMockServices()
        {
            _mockAlbumService = new Mock<IUserService<AlbumDtoModel>>();
            _mockPhotoService = new Mock<IUserService<PhotoDtoModel>>();

            _mockAlbumService
                .Setup(a => a.Get())
                .Returns(new List<AlbumDtoModel>()
                {
                    new AlbumDtoModel()
                    {
                        Id = 1,
                        Title = "Album 1",
                        UserId = 1,
                    },
                    new AlbumDtoModel()
                    {
                        Id = 2,
                        Title = "Album 2",
                        UserId = 2,
                    }
                });

            _mockPhotoService
                .Setup(x => x.Get())
                .Returns(new List<PhotoDtoModel>()
                {
                    new PhotoDtoModel()
                    {
                        Id = 1,
                        Title = "Photo 1, Album 1",
                        Url = new Uri("https://via.placeholder.com/600/771796"),
                        ThumbnailUrl = new Uri("https://via.placeholder.com/150/771796"),
                        AlbumId = 1
                    },
                    new PhotoDtoModel()
                    {
                        Id = 2,
                        Title = "Photo 2, Album 1",
                        Url = new Uri("https://via.placeholder.com/600/771796"),
                        ThumbnailUrl = new Uri("https://via.placeholder.com/150/771796"),
                        AlbumId = 1
                    },
                    new PhotoDtoModel()
                    {
                        Id = 3,
                        Title = "Photo 3, Album 2",
                        Url = new Uri("https://via.placeholder.com/600/771796"),
                        ThumbnailUrl = new Uri("https://via.placeholder.com/150/771796"),
                        AlbumId = 2
                    }
                });
        }
    }
}