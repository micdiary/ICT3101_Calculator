Feature: Logarthimic Model

    19. Allow the calculations of some quality metrics in the calculator
    
    20. Define some user story examples for the features

    As an engineer
    I want to calculate the failure intensity using the MUSA logarithmic model in the calculator 
    So that I can estimate the failure intensity of the system

    As an engineer
    I want to calculate the expected failures using the MUSA logarithmic model in the calculator
    So that I can estimate the expected failures of the system
   
    @LogarithmicModel
    Scenario: Failure Intensity
        Given I have a failure intensity
        When I calculate the failure intensity using logarithmic model with <decay> failure intensity decay, <intensity> failure intensity, and experienced a total of <failure> failures
        Then I get the current failure intensity of <ans>
        Examples:
            | decay | intensity | failure | ans  |
            | 0.02  | 10        | 50      | 3.68 |

    @LogarithmicModel
    Scenario: Expected Failures Logarithm Model
        Given I have a failure intensity
        When I calculate the expected failures using logarithmic model with <decay> failure intensity decay, <intensity> failure intensity, and <time> time
        Then I get the expected failures of <ans>
        Examples:
            | decay | intensity | time | ans |
            | 0.02  | 10        | 10   | 55  |