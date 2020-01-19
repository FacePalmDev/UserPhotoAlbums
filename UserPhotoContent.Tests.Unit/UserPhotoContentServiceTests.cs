// using System;
// using System.Collections.Generic;
// using Moq;
// using NUnit.Framework;
// using UserPhotoContent.Interfaces.Factories;
// using UserPhotoContent.Interfaces.Models;
//
// namespace UserPhotoContent.Tests.Unit
// {
//     public class UserPhotoContentServiceTests
//     {
//         [SetUp]
//         public void Setup()
//         {
//
//         }
//
//         [Test]
//         public void CanInstantiate()
//         {
//             var mockAlbumService = new Mock<TypiCodeAlbumService>();
//             var mockPhotoService = new Mock<TypiCodePhotoService>();
//             var mockContentFactory = new Mock<IFactory<IDomainModel>>();
//
//             var sut = new UserPhotoAlbumsService(
//                 mockAlbumService.Object,
//                 mockPhotoService.Object,
//                 mockContentFactory.Object);
//
//             Assert.IsNotNull(sut);
//         }
//
//         public void ShouldReturnTheCorrectNumberOfResults()
//         {
//
//             var fakeResult = new List<AlbumModel>()
//             {
//                 new AlbumModel()
//                 {
//                     Id = 1,
//                     UserId = 1,
//                     Title = "Image 1",
//                     Photos = new List<IPhotoDomainModel>()
//                     {
//                         new PhotoModel()
//                         {
//                             Id = 1,
//                             ThumbnailUrl = new Uri("http://www.example.com/thumb.png"),
//                             Title = "example",
//                             Url = new Uri("http://www.example.com/image.png")
//                         }
//                     }
//                 }
//             } as IEnumerable<IAlbumDomainModel>;
//             
//
//             var mockAlbumService = new Mock<TypiCodeAlbumService>();
//             var mockPhotoService = new Mock<TypiCodePhotoService>();
//             var mockContentFactory
//                 = new Mock<IFactory<IDomainModel>>()
//                     .Setup(x => x.())
//                     .Returns(fakeResult);
//
//             var sut = new UserPhotoAlbumsService(
//                 mockAlbumService.Object,
//                 mockPhotoService.Object,
//                 mockContentFactory.Object);
//
//             var actual = sut.Get(123);
//
//             IEnumerable<IDomainModel> expected = null;
//
//             Assert.AreEqual(expected, actual);
//         }
//     }
// }