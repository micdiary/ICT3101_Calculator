Feature: Defect Density

    19. Allow the calculations of some quality metrics in the calculator
    
    20. Define some user story examples for the features
    As an engineer
    I want to calculate the defect density of a system in the calculator
    So that I can estimate the number of defects in the system

    As an engineer
    I want to calculate the new total number of shipped source instructions (SSI) in the calculator
    So that I can estimate the number of lines of code in the system

    @Epic
    Scenario: Defect Density
        Given I have a number of defects
        When I divide the number of defects of <defects> by the number of Line Of Codes of <loc> into the calculator and press defect density
        Then I get the defect density of <density>
        Examples:
            | defects | loc | density |
            | 100     | 50  | 2       |

    @Epic
    Scenario: New Total Number of Shipped Source Instructions (SSI)
        Given I have a number of defects
        When I calculate the new SSI using CSI of <csi>, previous SSI of <ssi>, delete coded of <deleted> and changed code of <changed>
        Then I get the new total number of SSI of <ans>
        Examples:
            | csi | ssi | deleted | changed | ans |
            | 20  | 50  | 4       | 4       | 62  |






