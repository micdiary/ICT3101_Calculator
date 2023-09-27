Feature: UsingCalculatorFactorial
    Factorial

    @Factorial
    Scenario: Calculating Normal Factorial
        Given I have a calculator
        When I have entered 3 into the calculator and press Factorial
        Then the factorial result should be 6
    @Factorial
    Scenario: Calculating Zero Factorial
        Given I have a calculator
        When I have entered 0 into the calculator and press Factorial
        Then the factorial result should be 1
    @Factorial
    Scenario: Calculating Decimal Factorial
        Given I have a calculator
        When I have entered 3.5 into the calculator and press Factorial
        Then the factorial result should be "Cannot factorial decimal number"
    @Factorial
    Scenario: Calculating Negative Factorial
        Given I have a calculator
        When I have entered <input> into the calculator and press Factorial
        Then the factorial result should be "Cannot factorial negative number"
        Examples:
            | input |
            | -1    |
            | -2    |
            | -5    |
            | -10   |