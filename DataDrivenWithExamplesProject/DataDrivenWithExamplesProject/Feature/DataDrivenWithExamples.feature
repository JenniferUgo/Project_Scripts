Feature: DataDrivenWithParameter
	Simple calculator for adding two numbers

@mytag
Scenario Outline: Data Driven With Examples
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign Up
	And I enter my username text"<Username>"
	And I enter my email text "<Email>"
	And I enter my password text "<Password>"
	When I click on sign up button
	#Then I can register successfully

	Examples: 
	| Username | Email            | Password        |
	| Jennee   | demo098@test.com | Unkwownpassword |