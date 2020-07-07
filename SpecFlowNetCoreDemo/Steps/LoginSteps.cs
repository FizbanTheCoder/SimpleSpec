using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowNetCoreDemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowNetCoreDemo.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        // Anti-Contex injection code - 100% wrong
        LoginPage loginPage = null;

        //Step definitions
        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            loginPage = new LoginPage(webDriver);
        }

        [When(@"I click login link")]
        public void WhenIClickLoginLink()
        {
            loginPage.ClickLogin();
        }

        [When(@"I enter the following details")]
        public void WhenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.Login((string)data.UserName, (string)data.Password);
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should see Employee details link")]
        public void ThenIShouldSeeEmployeeDetailsLink()
        {
            Assert.That(loginPage.IsEmployeeDetailsExist(), Is.True);
        }

    }
}
