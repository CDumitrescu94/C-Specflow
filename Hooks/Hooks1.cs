using JuribaTaskImplementation.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace JuribaTaskImplementation.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private readonly ScenarioContext _scenarioContext;   

        [BeforeScenario]
        public void BeforeScenario()
        {
            IWebDriver webDriver = new FirefoxDriver();
            new InitializeWebDriver(webDriver);
        }

        [AfterScenario]
        public void AfterScenario() 
        {
            //InitializeWebDriver.CloseDriver();
        }
    }
}
