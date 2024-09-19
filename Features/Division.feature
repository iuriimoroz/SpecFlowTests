Feature: Division
Simple calculator for dividing two numbers

@mytag
Scenario: Divide two numbers
    Given the first number is 100
    And the second number is 25
    When the first number is divided by the second number
    Then the result should be 4
