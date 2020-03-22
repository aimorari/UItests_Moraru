Feature: Title Verification
	REQ-UI-01 The Title should be "UI Testing Site" on every site

Scenario: Page Title Verification
	Given A site with three pages
	When asserting home page title with the example it coincides
	Then navigate to Form page
	And verify page2 title
	Then navigate to error page
	And verify error page title
	Then close the browser