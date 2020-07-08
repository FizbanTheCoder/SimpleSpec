using Dynamitey.Internal.Optimization;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SpecFlowNetCoreDemo.Pages
{
    class MainPage
    {
        public IWebDriver WebDriver { get; }

        public MainPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement inpudFrom => WebDriver.FindElement(By.Id("from.text"));
        public IWebElement inputTo => WebDriver.FindElement(By.Id("to.text"));
        public IWebElement radioReturn => WebDriver.FindElement(By.Id("return"));
        public IWebElement inputOutboundDate => WebDriver.FindElement(By.Id("page.journeySearchForm.outbound.title"));
        public IWebElement inputInBoundDate => WebDriver.FindElement(By.Id("page.journeySearchForm.inbound.title"));
        public IWebElement inputOutbondHours => WebDriver.FindElement(By.XPath("//*[@data-test='outbound-datepicker']//*[@name='hours']"));
        public IWebElement inputOutbondMinutes => WebDriver.FindElement(By.XPath("//*[@data-test='outbound-datepicker']//*[@name='minutes']"));
        public IWebElement inputInbondHours => WebDriver.FindElement(By.XPath("//*[@data-test='inbound-datepicker']//*[@name='hours']"));
        public IWebElement inputInbondMinutes => WebDriver.FindElement(By.XPath("//*[@data-test='inbound-datepicker']//*[@name='minutes']"));
        public IWebElement submitBtn => WebDriver.FindElement(By.XPath("//*[@data-test='submit-journey-search-button']"));
        public IWebElement adultNe => WebDriver.FindElement(By.XPath("//*[@data-test='passenger-picker-adults']"));
        public IWebElement selectre => WebDriver.FindElement(By.ClassName("_u8v19d"));
        public IWebElement childrenNumber => WebDriver.FindElement(By.Name("Children"));
        public IWebElement childrenAge => WebDriver.FindElement(By.Name(""));

            public void ChooseOutInPlace(string outboundPlace, string inBoundPlace)
        {
            inpudFrom.SendKeys(outboundPlace);
            inputTo.SendKeys(inBoundPlace);
        }

        public void ClickRadioReturn() => radioReturn.Click();

        public void InputTodayDate()
        {
            String actualDate = DateTime.Now.ToString("dd'-'MMMM'-'yy");
            inputOutboundDate.Click();
            inputOutboundDate.Clear();
            inputOutboundDate.SendKeys(actualDate);
            inputOutboundDate.Click();
        }

        public void InputActualPlusOneHour() {
            String actualHour = DateTime.Now.AddHours(1).Hour.ToString();
            Console.WriteLine("2222222222222222222222--->" + actualHour);
            inputOutbondHours.SendKeys(actualHour);
        }

        public void backAfterDay(int days) {
            string backDate = DateTime.Now.AddDays(days).ToString("dd'-'MMMMM'-'yy");
            inputInBoundDate.Click();
            inputInBoundDate.Clear();
            inputInBoundDate.SendKeys(backDate);
            inputInBoundDate.Click();
        }

        public void inputInboardHour(string hour) {
            inputInbondHours.SendKeys(hour);
        }

        public MainPage confirmRequest() {
            submitBtn.Click();
            return new MainPage(WebDriver);
        }

        public void addRailCards(string value) {
            selectre.Click();
            var selectAdultNumber = new SelectElement(adultNe);
            selectAdultNumber.SelectByText(value);

        }
    }
}
