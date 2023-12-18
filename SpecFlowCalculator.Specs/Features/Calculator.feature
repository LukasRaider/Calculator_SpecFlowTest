Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@ADD
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120
@SUBTRACT
Scenario: Subtract two numbers
Given the first number is 150
And the second number is 80
When the two numbers are subtract
Then the result should be 70
@MULTIPLICATION
Scenario: Multiplication two numbers
Given the first number is 10
And the second number is 5
When the two numbers are multiplication
Then the result should be 50
@DIVISION
Scenario: Division two numbers
Given the first number is 30
And the second number is 2
When the two numbers are division
Then the result should be 15
@RESIDUE
Scenario: Residue two numbers
Given the first number is 35
And the second number is 3
When the two number are residue
Then the result should be 2
@EMPOWERMENT
Scenario: EmpowermentFirstNumber
Given the first number is 5
When number is empowermentFirst
Then the result should be 25
@EMPOVERMENT
Scenario: EmpowermentSecondNumber
Given the second number is -9
When number is empowermentSecond
Then the result should be 81