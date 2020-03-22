Feature: Home Page UI
	REQ-UI-09 The following text should be visible on the Home page in <h1> tag:
"Welcome to the Docler Holding QA Department"
	REQ-UI-10 The following text should be visible on the Home page in <p> tag:
"This site is dedicated to perform some exercises and demonstrate automated web testing."

Scenario: Home Page UI
	Given HOME page with heading text
	And paragraph text