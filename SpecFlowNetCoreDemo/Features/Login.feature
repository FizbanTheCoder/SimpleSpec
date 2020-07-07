Feature: Login
	Login to EA Demo applicaiton

@smoke
Scenario: Perform Login of EA Application site
	Given I launch the application
	When I click login link
	And  I enter the following details
		| UserName | Password |
		| admin    | password |
	And I click login button
	Then I should see Employee details link
