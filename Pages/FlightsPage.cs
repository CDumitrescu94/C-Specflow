using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using JuribaTaskImplementation.Drivers;

namespace JuribaTaskImplementation.Pages
{
    class FlightsPage : BasePage
    {
        public FlightsPage(IWebDriver _webDriver) : base(_webDriver) { }

        public IWebElement searchFlightContainer => _webDriver.FindElement(By.ClassName("Ui-Searchforms-Flights-Components-FlightSearchForm-container"), 10);
        public IWebElement ticketTypeDropBox => searchFlightContainer.FindElement(By.XPath("//*[@class='zcIg']//*[@class='wIIH-handle'][1]"));
        public IWebElement flightOriginInput => _webDriver.FindElement(By.CssSelector("[aria-label = 'Flight origin input']"));
        public IWebElement flightDestinationInput => _webDriver.FindElement(By.CssSelector("[aria-label = 'Flight destination input']"));
        public IWebElement flightDeparteAndDestinationContainer => _webDriver.FindElement(By.XPath("//*[@aria-label='Departure and destination dates input']"));
        public IWebElement flightDepartureDate => _webDriver.FindElement(By.XPath("//*[@aria-label='Departure and destination dates input']//*[@class='cQtq-input'][1]"));
        public IWebElement flightDestinationDate => _webDriver.FindElement(By.XPath("//*[@aria-label='Departure and destination dates input']//*[@class='cQtq-input'][2]"));
        public IWebElement searchFlightBtn => _webDriver.FindElement(By.CssSelector("[aria-label = 'Search']"));

        public void SelectTicketType(String type)
        {
            ticketTypeDropBox.Click();
            _webDriver.FindElement(By.XPath($"//li//span[text()= '{type}']"), 10).Click();
        }
        
        public IList<IWebElement> GetFlightOrigins()
        {
            return flightOriginInput.FindElements(By.ClassName("vvTc-item"));
        }
        public void ClearFlightOriginInput()
        {
            IList<IWebElement> flightOrigins = GetFlightOrigins();
            foreach (IWebElement flightOrigin in flightOrigins)
                flightOrigin.FindElement(By.ClassName("vvTc-item-close")).Click();
        }
        public bool FlightDestinationDateExists()
        {
            if (flightDeparteAndDestinationContainer.FindElements(By.XPath("//*[@class='cQtq-input'][2]")).Count != 0)
                return true;
            return false;
        }
        public void SearchFlight()
        {
            searchFlightBtn.Click();
        }

        public bool AirportNotSelectedDialogIsDisplayed()
        {
            if (_webDriver.FindElements(By.LinkText("You didn't select an airport")).Count != 0)
                return true;
            return false;
        }
        public bool FlightOriginDestinationInputDialogIsDisplayed()
        {
            if (dialog.FindElements(By.CssSelector("[placeholder = 'From?']")).Count != 0)
                return true;
            return false;
        }
        public bool SignInSignUpOptionIsDisplayed()
        {
            if (dialog.FindElements(By.XPath("//*[contains(text(), 'Sign in')]")).Count != 0)
                return true;
            return false;
        }
    }
}
