Feature: SearchFlights
	Testint Flight Search


Scenario: Sign in Sign up option should be displayed if no flights are selected
	Given I start the application
	And I navigate to flights
	When I clear flight origin input
	Then Flight origin input dialog should appear
	And Sign in Sign up option should be displayed in flight origin input