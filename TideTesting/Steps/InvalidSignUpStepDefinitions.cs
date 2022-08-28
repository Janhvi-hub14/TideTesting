using System;
using TechTalk.SpecFlow;

namespace TideTesting.Steps
{
    [Binding]
    public class InvalidSignUpStepDefinitions
    {
        [Given(@"website link open")]
        public void GivenWebsiteLinkOpen()
        {
            throw new PendingStepException();
        }

        [When(@"user have to click on register button")]
        public void WhenUserHaveToClickOnRegisterButton()
        {
            throw new PendingStepException();
        }

        [When(@"user have to click on SIGN UP button")]
        public void WhenUserHaveToClickOnSIGNUPButton()
        {
            throw new PendingStepException();
        }

        [When(@"user enters the Invalid Username ,Email ID,Password")]
        public void WhenUserEntersTheInvalidUsernameEmailIDPassword()
        {
            throw new PendingStepException();
        }

        [When(@"user have to Click on SignUp")]
        public void WhenUserHaveToClickOnSignUp()
        {
            throw new PendingStepException();
        }

        [Then(@"it should not create account for user and should display error message")]
        public void ThenItShouldNotCreateAccountForUserAndShouldDisplayErrorMessage()
        {
            throw new PendingStepException();
        }
    }
}
