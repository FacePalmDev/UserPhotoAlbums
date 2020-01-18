using System;
using TechTalk.SpecFlow;

namespace UserPhotoContent.Tests.Integration
{
    [Binding]
    public class RetrivingUserPhotoContentSteps
    {
        [Given(@"The user does not have any content")]
        public void GivenTheUserDoesNotHaveAnyContent()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have (.*) and (.*)")]
        public void GivenIHaveAnd(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the data is requested in ""(.*)"" format")]
        public void WhenTheDataIsRequestedInFormat(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        

        
        [Then(@"the resulting HTTP Status code should be (.*)")]
        public void ThenTheResultingHTTPStatusCodeShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
  
        
        [Then(@"the result should contain (.*) photos")]
        public void ThenTheResultShouldContainPhotos(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should contain (.*) albums")]
        public void ThenTheResultShouldContainAlbums(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The content should be formatted as (.*)")]
        public void ThenTheContentShouldBeFormattedAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
