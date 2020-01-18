using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using UserPhotoContent.Api.Controllers;
using UserPhotoContent.Api.Services;

namespace UserPhotoContent.Tests.Unit.UserContent
{
    public class UserPhotoContentServiceTests
    {
        

        [SetUp]
        public void Setup()
        { 
            
        }

        [Test]
        public void CanInstantiate()
        {
            var sut = new UserPhotoContentService();
            Assert.IsNotNull(sut);
        }

    }
}