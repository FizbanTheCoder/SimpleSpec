using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowNetCoreDemo.Steps
{
    [Binding]
    public sealed class LoginSteps
    {

        //Step definitions
        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"I click login link")]
        public void WhenIClickLoginLink()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter the following details")]
        public void WhenIEnterTheFollowingDetails(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see Employee details link")]
        public void ThenIShouldSeeEmployeeDetailsLink()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
