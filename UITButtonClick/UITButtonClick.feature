Feature: Click on UI Testing button
	REQ-UI-08 When I click on the UI Testing button, I should get navigated to the Home page
Scenario: Click on UI Testing button
	Given a site with the UI Testing button
	When click on UI Testing button, HOME page displayed
	Then on FORM page clicked on UI Testing button, the HOME page displayed