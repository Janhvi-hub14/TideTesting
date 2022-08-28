using System;
using TechTalk.SpecFlow;
using TideTesting.Tests;

namespace TideTesting.Steps
{
    [Binding]
    public class ContactUsStepDefinitions
    {
        ContactTest Con = new ContactTest();
        public void GivenBrowseUrl()
        {
            Con.OpenUrl();
        }

        [When(@"click on contact us")]
        public void WhenClickOnContactUs()
        {
            Con.ClickOnContactUs();
        }

        [Then(@"it should display user contact us options")]
        public void ThenItShouldDisplayUserContactUsOptions()
        {
            Con.DisplayOptions();
        }
    }
}
