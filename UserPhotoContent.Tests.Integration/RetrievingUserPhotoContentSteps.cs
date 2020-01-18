using System;
using TechTalk.SpecFlow;

namespace UserPhotoContent.Tests.Integration
{
    [Binding]
    public class RetrievingUserPhotoContentSteps
    {
        private readonly ScenarioContext _context;

        public RetrievingUserPhotoContentSteps(ScenarioContext context)
        {
            _context = context;
        }

        [Given(@"The user does not have any content")]
        public void GivenTheUserDoesNotHaveAnyContent()
        {
            _context.Pending();
        }
        
        [Given(@"I have (.*) and (.*)")]
        public void GivenIHaveAnd(int p0, int p1)
        {
            _context.Pending();
        }
        
        [When(@"the data is requested in ""(.*)"" format")]
        public void WhenTheDataIsRequestedInFormat(string p0)
        {
            _context.Pending();
        }
        
        [Then(@"the resulting HTTP Status code should be (.*)")]
        public void ThenTheResultingHttpStatusCodeShouldBe(int p0)
        {
            _context.Pending();
        }
        
        [Then(@"the result should contain (.*) photos")]
        public void ThenTheResultShouldContainPhotos(int p0)
        {
            _context.Pending();
        }
        
        [Then(@"the result should contain (.*) albums")]
        public void ThenTheResultShouldContainAlbums(int p0)
        {
            _context.Pending();
        }
        
        [Then(@"The content should be formatted as (.*)")]
        public void ThenTheContentShouldBeFormattedAs(string p0)
        {
            _context.Pending();
        }
    }
}
