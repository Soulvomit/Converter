Feature: Celcius-Fahrenheit Converter

Scenario: Convert celsius to fahrenheit
	Given celsius input is 50.0
	When toFahrenhiet button is pressed
	Then fahrenhiet output should be 122.0

Scenario: Clamp fahrenheit to absolute zero (-459.67 fahrenheit)
	Given celsius input is below absolute zero in fahrenheit 
	When toFahrenhiet button is pressed
	Then fahrenheit output should be absolute zero

Scenario: Handle non-numeric format input
	Given celsius input is invalid number
	When toFahrenhiet button is pressed
	Then write an invalid number error message

Scenario: Handle integer overflow
	Given fahrenhiet output or celsius input is above a floats max value
	Then write an above max value error message 

Scenario: Handle integer underflow
	Given fahrenhiet output or celsius input is below a floats min value
	Then write an below min value error message
