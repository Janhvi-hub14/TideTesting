Feature: Language

A short summary of the feature

@tag1
Scenario: WebpageLanguageChange
	Given visit webpage by url
	When user click on language change dropdown button
	And select any language option from availaible options
	Then It should Display the web page into that language
