Feature: Logo Visible
	REQ-UI-02 The Company Logo should be visible on every site

Scenario: Company Logo Visible
	Given A site with the company logo
	When page displayed logo have to be visible
	Then on the FORM page logo have to visible
	And on the ERROR page logo have to be visible