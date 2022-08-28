using System;
using TechTalk.SpecFlow;

namespace TideTesting.Steps
{
    [Binding]
    public class InvalidLoginStepDefinitions
    {
        [Given(@"open webpage")]
        public void GivenOpenWebpage()
        {
            throw new PendingStepException();
        }

        [When(@"click on register button")]
        public void WhenClickOnRegisterButton()
        {
            throw new PendingStepException();
        }

        [When(@"click on LOGIN button")]
        public void WhenClickOnLOGINButton()
        {
            throw new PendingStepException();
        }

        [When(@"user enters the Valid Email ID & InvalidPassword")]
        public void WhenUserEntersTheValidEmailIDInvalidPassword()
        {
            throw new PendingStepException();
        }

        [When(@"user Click on Login button")]
        public void WhenUserClickOnLoginButton()
        {
            throw new PendingStepException();
        }

        [Then(@"it should not Login to user Account")]
        public void ThenItShouldNotLoginToUserAccount()
        {
            throw new PendingStepException();
        }
    }
}
