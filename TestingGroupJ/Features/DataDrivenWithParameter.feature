Feature: DataDrivenWithParameter
	Simple calculator for adding two numbers

@mytag
Scenario: Data Driven With Parameter
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign Up
	And I enter my username "jennee"
	And I enter my email"demo212"
	And I enter my password "passwordsecure"
	When I click on sign up button
	#Then I can register successfully