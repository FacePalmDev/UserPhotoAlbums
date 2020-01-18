using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace UserPhotoContent.Tests.Integration
{
    [Binding]
    public class RetrievingUserPhotoContentSteps
    { 

        [Given(@"The user does not have any content")]
        public void GivenTheUserDoesNotHaveAnyContent()
        {
           Assert.Fail();
        }
        
        [Given(@"The user has (.*) and (.*)")]
        public void GivenTheUserHasAnd(int noPhotos, int noAlbums)
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
           Assert.Fail();
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
