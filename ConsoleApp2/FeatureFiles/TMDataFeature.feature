Feature: TMFeature
	As the turn up portal admin
	I would like to create new time and material record
	in a single page

@tm @automate
Scenario: Turn up admin should be able to create a time and material record successfully
	Given I have logged in to Turn Up portal
	And I have navigated to the Time and Material page
	Then I should be able to create a Time and Material record successfully

@tm @automate
Scenario: Turn up admin should be able to edit a time and material record successfully
	Given I have logged in to Turn Up portal
	And I have navigated to the Time and Material page
	Then I should be able to edit a Time and Material record successfully

@tm @automate
Scenario: Turn up admin should be able to delete a time and material record successfully
	Given I have logged in to Turn Up portal
	And I have navigated to the Time and Material page
	Then I should be able to delete a Time and Material record successfully
