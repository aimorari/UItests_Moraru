Feature: Hello Page greeting
	On the Form page, if you type <value> the input field and submit the form,
	you should get redirect to the Hello page, and the following text should appear: <result>

Scenario Outline: Hello page greeting
	Given an input value of name as <name> and submitted
	Then the following greeting displayed <greeting>

	Examples:
			| name      | greeting         |
			| "John"    | "Hello John"     |
			| "Sophia"  | "Hello Sophia!"  |
			| "Charlie" | "Hello Charlie!" |
			| "Emily"   | "Hello Emily!"   |
