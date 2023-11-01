@setup_feature
Feature: SortPostCodeSteps

  Scenario: Bank Manager sorts customers by Post Code
    Given I navigate to the Bank Manager Login page
    When I log in as Bank Manager
    And I go to Customers
    Then I sort elements by Post Code
    And I should see the expected results
