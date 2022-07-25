@draft7

Feature: multipleOf draft7
    In order to use json-schema
    As a developer
    I want to support multipleOf in draft7

Scenario Outline: by int
/* Schema: 
{"multipleOf": 2}
*/
    Given the input JSON file "multipleOf.json"
    And the schema at "#/0/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        | #/000/tests/000/data | true  | int by int                                                                       |
        | #/000/tests/001/data | false | int by int fail                                                                  |
        | #/000/tests/002/data | true  | ignores non-numbers                                                              |

Scenario Outline: by number
/* Schema: 
{"multipleOf": 1.5}
*/
    Given the input JSON file "multipleOf.json"
    And the schema at "#/1/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        | #/001/tests/000/data | true  | zero is multiple of anything                                                     |
        | #/001/tests/001/data | true  | 4.5 is multiple of 1.5                                                           |
        | #/001/tests/002/data | false | 35 is not multiple of 1.5                                                        |

Scenario Outline: by small number
/* Schema: 
{"multipleOf": 0.0001}
*/
    Given the input JSON file "multipleOf.json"
    And the schema at "#/2/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        | #/002/tests/000/data | true  | 0.0075 is multiple of 0.0001                                                     |
        | #/002/tests/001/data | false | 0.00751 is not multiple of 0.0001                                                |

Scenario Outline: invalid instance should not raise error when float division  equals  inf
/* Schema: 
{"type": "integer", "multipleOf": 0.123456789}
*/
    Given the input JSON file "multipleOf.json"
    And the schema at "#/3/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        | #/003/tests/000/data | false | always invalid, but naive implementations may raise an overflow error            |
