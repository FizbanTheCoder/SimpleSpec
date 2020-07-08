Feature: Searching a train by clien

As a user I want find proper train.B

@smoke
Scenario: Finding today train
	Given I launch thetrainline site
	When I chose start place and destination place
		| StartPlace         | DestinationPlace |
		| Manchester Airport | London Bridge    |
	And I want click on 'Return' radio button
	And I want go today after one hour 
	And I want return after '3' days at '10'
	And I want reserve ticket for
		| Adult | Children | AgeOfChildren |
		| 2     | 2        | 5-15          |
	And I want confirm my request
	Then I want see resulof my request


