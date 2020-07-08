using Dynamitey.Internal.Optimization;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SpecFlowNetCoreDemo.Pages
{
    class ResultPage
    {

        public IWebDriver WebDriver { get; }

        public ResultPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
    }
}
