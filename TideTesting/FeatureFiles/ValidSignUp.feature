Feature: ValidSignUp

A short summary of the feature

@tag1
Scenario: SignupWithValidDetails
	Given website link
	When user click on register button
	And user click on SIGN UP button 
	And user enters the valid Username ,Email ID,Password
	And Click on SignUp
	Then it should create accoun for user
