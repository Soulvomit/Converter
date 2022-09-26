using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterProject
{
    internal class Formatter
    {
        /// <summary>
        /// Clamps the value between -3999 and 3999. These are the minimum and maximum roman numeral values.
        /// </summary>
        /// <param name="romanNumeral">input integer</param>
        /// <returns>a value between -3999 and 3999</returns>
        internal static int ClampToRomanNumeralMaxMinValue(int romanNumeral)
        {
            return Math.Clamp(romanNumeral, -3999, 3999);
        }
        /// <summary>
        /// Checks if input string is of valid numerc format and converts to 32-bit integer.
        /// </summary>
        /// <param name="stringNumeral">input string</param>
        /// <returns>null = conversion failed; any integer value = conversion success</returns>
        internal static float? ConvertStringToNumeric(string stringNumeral)
        {
            try
            {
                checked
                {
                    float i;
                    bool parsed = float.TryParse(stringNumeral, out i);
                    if (!parsed) return null;
                    else return i;
                }
            }
            catch (OverflowException)
            {
                return null;
            }
        }
        /// <summary>
        /// Clamps the fahrenheit float value between fahrenheit absolute zero and float.MaxValue.
        /// </summary>
        /// <param name="fahrenhiet">fahrenhiet input</param>
        /// <returns>a value between fahrenheit absolute zero and float.MaxValue</returns>
        internal static float ClampFahrenhietToAbsolutZero(float fahrenhiet)
        {
            return Math.Clamp(fahrenhiet, -459.67f, float.MaxValue);
        }
        /// <summary>
        /// Clamps the celsius float value between fahrenheit absolute zero and float.MaxValue.
        /// </summary>
        /// <param name="fahrenhiet">celsius input</param>
        /// <returns>a value between celsius absolute zero and float.MaxValue</returns>
        internal static float ClampCelsiusToAbsolutZero(float celsius)
        {
            return Math.Clamp(celsius, -273.15f, float.MaxValue);
        }
    }
}
