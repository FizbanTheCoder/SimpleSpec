using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowNetCoreDemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowNetCoreDemo.Steps
{
    [Binding]
    public sealed class SearchingATrainnByClientSteps
    {

        MainPage mainPage = null;

        [Given(@"I launch thetrainline site")]
        public void GivenILaunchThetrainlineSite()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.thetrainline.com/");
            mainPage = new MainPage(webDriver);
        }

        [When(@"I chose start place and destination place")]
        public void WhenIChoseStartPlaceAndDestinationPlace(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            mainPage.ChooseOutInPlace((string)data.StartPlace, (string)data.DestinationPlace);
        }

        [When(@"I want click on '(.*)' radio button")]
        public void WhenIWantClickOnRadioButton(string ticketOptions)
        {
            //napisac switch
            switch (ticketOptions) { 
                case "One Way":
                    Console.WriteLine("One Way");
                    break;
                case "Return":
                    mainPage.ClickRadioReturn();
                    break;
                case "Open Return":
                    Console.WriteLine("OpenReturn");
                    break;
                default:
                    Console.WriteLine("One Way");
                    break;
            }
        }



        [When(@"I want go today after one hour")]
        public void WhenIWantGoTodayAtHour()
        {
            mainPage.InputTodayDate();
            mainPage.InputActualPlusOneHour();
        }

        [When(@"I want return after '(.*)' days at '(.*)'")]
        public void WhenIWantReturnAfterDaysAt(int p0, string p1)
        {
            mainPage.backAfterDay(p0);
            mainPage.inputInboardHour(p1);
        }

        [When(@"I want reserve ticket for")]
        public void WhenIWantReserveTicketFor(Table table)
        {
            String value = "2";
            mainPage.addRailCards(value);
        }

        [When(@"I want confirm my request")]
        public void WhenIWantConfirmMyRequest()
        {
            mainPage.confirmRequest();
        }

        [Then(@"I want see resulof my request")]
        public void ThenIWantSeeResulofMyRequest()
        {
           
        }

    }
}
