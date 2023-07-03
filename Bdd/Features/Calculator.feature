Feature: Calculator
base template from specflow

Background:
	Given the first number is 70
	When the two numbers are added
	Then the result should be 120

@mytag
Scenario Outline: Add two numbers
	Given the second number is <SecondNumber>
	When the two numbers are added
	Then the result should be <Result>

Examples:
	| SecondNumber | Result |
	| 50           | 120    |
	| 55           | 125    |
	| 60           | 130    |
	| 70           | 140    |
	| 75           | 145    |