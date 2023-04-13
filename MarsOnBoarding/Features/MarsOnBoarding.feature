Feature: MarsOnBoarding
I would like to be able to sign in to Mars portal
Then I would like to add, edit and delete my details


Scenario: Test 1 -  Add language to my profile
	Given I launch and log into Mars portal successfully
	When I add new language
	Then The new language should be added successfully


Scenario: Test 2 - Edit the added language 
	Given I launch and log into Mars portal successfully
	When I edit the added language
	Then The edited language should be added successfully


Scenario: Test 3 - Delete added language 
	Given I launch and log into Mars portal successfully
	When I delete the added language
	Then The added language should be deleted successfully

