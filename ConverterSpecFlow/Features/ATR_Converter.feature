Feature: Arabic-Roman Numeral Converter

Scenario: Convert arabic numerals to roman numerals
	Given integar input is 10
	When toRoman button is pressed
	Then roman numeral output should be "X"

Scenario: Handle non-numeric format input
	Given integer input is an invalid integer
	When toRoman button is pressed
	Then write an invalid number error message

Scenario: Handle roman numeral overflow (3999 or MMMCMXCIX)
	Given arabic numeral input is above max roman numeral 
	When output is written on screen
	Then write an above max value error message 

Scenario: Handle integer underflow (-3999 or -MMMCMXCIX)
	Given arabic numeral input is below min roman numeral
	When output is written on screen
	Then write an below min value error message