using JuribaTaskImplementation.Drivers;
using JuribaTaskImplementation.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace JuribaTaskImplementation.Steps
{
    [Binding]
    public sealed class SearchFligthsStepDefinitions
    {
        FlightsPage flightsPage = new FlightsPage(InitializeWebDriver._webDriver);

        [Given(@"I start the application")]
        public void GivenIStartTheApplication()
        {
            InitializeWebDriver.Navigate(Constants.appUrl);
            InitializeWebDriver.AcceptCookies();
        }

        [Given(@"I navigate to flights")]
        public void GivenINavigateToFlights()
        {
            flightsPage.navFlights.Click();
        }

        [When(@"I select the type of ticket ""(.*)""")]
        public void WhenISelectTheTypeOfTicket(string ticketType)
        {
            flightsPage.SelectTicketType(ticketType);
        }

        [Then(@"the return date input should not be displayed")]
        public void ThenTheReturnDateInputShouldNotBeDisplayed()
        {
            Assert.That(flightsPage.FlightDestinationDateExists, Is.False);
        }

        [When(@"I search a flight")]
        public void WhenISearchAFlight()
        {
            flightsPage.searchFlightBtn.Click();
        }

        [Then(@"Dialog window should popup")]
        public void ThenDialogWindowShouldPopup()
        {
            flightsPage.AirportNotSelectedDialogIsDisplayed();
        }
        [When(@"I clear flight origin input")]
        public void WhenIClearFlightOriginInput()
        {
            flightsPage.ClearFlightOriginInput();
        }

        [When(@"I open flight origin input dialog")]
        public void WhenIOpenFlightOriginInputDialog()
        {
            flightsPage.flightOriginInput.Click();
        }

        [Then(@"Flight origin input dialog should appear")]
        public void ThenFlightOriginInputDialogShouldAppear()
        {
            Assert.That(flightsPage.FlightOriginDestinationInputDialogIsDisplayed, Is.True);
        }

        [Then(@"Sign in Sign up option should be displayed in flight origin input")]
        public void ThenSignInSignUpOptionShouldBeDisplayedInFlightOriginInput()
        {          
            Assert.That(flightsPage.SignInSignUpOptionIsDisplayed, Is.True);
        }


    }
}
