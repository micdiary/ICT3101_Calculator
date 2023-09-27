Feature: Reliability
    In order to calculate the Basic Musa model's failures/intensities
    As a Software Quality Metric enthusiast
    I want to use my calculator to do this

    @Reliability
    Scenario: Calculating Current Failure Intensity for Basic Musa Model
        Given I have a Basic Musa Model
        When I have entered <initial> and <average> and <total> into the calculator and press Current Failure Intensity
        Then the reliability result should be  <Current>
        Examples:
            | initial | average | total | Current |
            | 10      | 50      | 100   | 5       |


    @Reliability
    Scenario: Calculating Average Number of Expected Failures for Basic Musa Model
        Given I have a Basic Musa Model
        When I have entered <time> and <initial> and <total> into the calculator and press Average Number of Expected Failures
        Then the reliability result should be  <Average>
        Examples:
            | time | initial | total | Average |
            | 100  | 10      | 100   | 100     |