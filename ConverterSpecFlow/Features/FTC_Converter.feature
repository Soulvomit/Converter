Feature: Fahrenheit-Celcius Converter

Scenario: Convert fahrenheit to celsius
	Given fahrenhiet input is 50.0
	When toCelsius button is pressed
	Then celsius output should be 10.0

Scenario: Clamp fahrenheit to absolute zero (-273.15 celsius)
	Given fahrenhiet input is below absolute zero in celsius
	When toCelsius button is pressed
	Then celsius output should be absolute zero

Scenario: Handle non-numeric format input
	Given fahrenhiet input is invalid number
	When toCelsius button is pressed
	Then write an invalid number error message

Scenario: Handle float overflow
	Given celsius output or fahrenhiet input is above a floats max value
	Then write an above max value error message

Scenario: Handle float underflow
	Given celsuis output or fahrenhiet input is below a floats min value
	Then write an below min value error message