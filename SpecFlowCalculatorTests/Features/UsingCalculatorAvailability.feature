Feature: UsingCalculatorAvailability
    In order to calculate MTBF and Availability
    As someone who struggles with math
    I want to be able to use my calculator to do this
    @Availability
    Scenario: Calculating MTBF
        Given I have a calculator
        When I have entered <MTTF> and <MTTR> into the calculator and press MTBF
        Then the availability result should be <MTBF>
        Examples:
            | MTTF | MTTR | MTBF |
            | 100  | 20   | 120  |
            | 200  | 30   | 230  |
            | -300  | 40   | "Cannot have negative number"  |


    @Availability
    Scenario: Calculating Availability
        Given I have a calculator
        When I have entered <MTTF> and <MTBF> into the calculator and press Availability
        Then the availability result should be <Availability>
        Examples:
            | MTTF | MTBF | Availability |
            | 200  | 400  | 0.5          |
            | 300  | 200  | "MTTF cannot be lower than MTBF" |