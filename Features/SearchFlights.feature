Feature: SearchFlights
	Testint Flight Search


Scenario: Destination date is not displayed if the ticket is One-way
	Given I start the application
	And I navigate to flights
	When I select the type of ticket "One-way"
	Then the return date input should not be displayed

Scenario: Search flight without destination selected
	Given I start the application
	And I navigate to flights
	When I search a flight
	Then Dialog window should popup

Scenario: Sign in Sign up option should be displayed if no flights are selected
	Given I start the application
	And I navigate to flights
	When I clear flight origin input
	Then Flight origin input dialog should appear
	And Sign in Sign up option should be displayed in flight origin input