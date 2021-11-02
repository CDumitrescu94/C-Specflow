using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuribaTaskImplementation.Pages
{
    public abstract class BasePage
    {
        public IWebDriver _webDriver;

        public BasePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public IWebElement navFlights => _webDriver.FindElement(By.CssSelector("[aria-label = 'Search for flights']"));
        public IWebElement navCars => _webDriver.FindElement(By.CssSelector("[aria-label = 'Search for cars']"));

        public IWebElement dialog => _webDriver.FindElement(By.CssSelector("[role = 'dialog']"));

    }
}
