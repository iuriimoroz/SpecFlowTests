Feature: Multiplication
Simple calculator for multiplying two numbers

@mytag
Scenario: Multiply two numbers
    Given the first number is 10
    And the second number is 20
    When the two numbers are multiplied
    Then the result should be 200
