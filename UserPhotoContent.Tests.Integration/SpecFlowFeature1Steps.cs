using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace UserPhotoContent.Tests.Integration
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private readonly ScenarioContext _context;

        public SpecFlowFeature1Steps(ScenarioContext context)
        {
            _context = context;
        }
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _context.Pending();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _context.Pending();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            _context.Pending();
        }
    }
}
