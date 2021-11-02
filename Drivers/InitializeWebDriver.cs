using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuribaTaskImplementation.Drivers
{
    class InitializeWebDriver
    {
        public static IWebDriver _webDriver;

        public InitializeWebDriver(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public static void Navigate(String url)
        {
            _webDriver.Navigate().GoToUrl(url);     
        }

        public static void AcceptCookies()
        {
           IWebElement acceptButton = _webDriver.FindElement(By.CssSelector("[aria-label = 'Accept']"), 3);
           var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(3));
           wait.Until(drv => acceptButton.Displayed);
           acceptButton.Click();
        }

        public static void CloseDriver()
        {
            _webDriver.Quit();
        }
    }
}
