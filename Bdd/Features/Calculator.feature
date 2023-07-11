Feature: Calculator
base template from specflow

@DataSource:Data/TestData.xlsx @DataSet:Account @Calculator
Scenario Outline: Add two numbers
	Given the first number is <FirstNumber>
	Given the second number is <SecondNumber>
	When the two numbers are added
	Then the result should be <Result>

Examples:
	| FirstNumber | SecondNumber | Result |
	| 70          | 50           | 120    |
	| 70          | 55           | 125    |
	| 70          | 60           | 130    |
	| 70          | 70           | 140    |
	| 70          | 75           | 145    |
	| 70          | 75           | 145    |

@Calculator	
Scenario Outline: Table
	Given the following users exist:
		| Author        | Title                          |
		| Martin Fowler | Analysis Patterns              |
		| Gojko Adzic   | Bridging the Communication Gap |
