namespace ConverterProject
{
    public class Converter
    {
        public Converter()
        {
        }
        public float? ToFahrenheit(float celcius) 
        {
            return Formatter.ClampFahrenhietToAbsolutZero((celcius * 1.8f) + 32f);
        }
        public float? ToCelsius(float fahrenheit) 
        {
            return Formatter.ClampCelsiusToAbsolutZero((fahrenheit - 32f) * .5556f);
        }
        public float? ToNumeric(string input)
        {
            return Formatter.ConvertStringToNumeric(input);
        }
        public string ToRoman(int arabicNumber) 
        {
            int temp = Formatter.ClampToRomanNumeralMaxMinValue(arabicNumber);
            
            if (temp == 0) return "0";

            string roman = "";
            
            if (temp < 0)
            {
                temp = Math.Abs(temp);
                roman += "-";
            }
            while (temp != 0)
            {
                if (temp - 1000 >= 0)
                {
                    temp -= 1000;
                    roman += "M";
                }
                else if (temp - 900 >= 0)
                {
                    temp -= 900;
                    roman += "CM";
                }
                else if (temp - 500 >= 0)
                {
                    temp -= 500;
                    roman += "D";
                }
                else if (temp - 400 >= 0)
                {
                    temp -= 400;
                    roman += "CD";
                }
                else if (temp - 100 >= 0)
                {
                    temp -= 100;
                    roman += "C";
                }
                else if (temp - 90 >= 0)
                {
                    temp -= 90;
                    roman += "XC";
                }
                else if (temp - 50 >= 0)
                {
                    temp -= 50;
                    roman += "L";
                }
                else if (temp - 40 >= 0)
                {
                    temp -= 40;
                    roman += "XL";
                }
                else if (temp - 10 >= 0)
                {
                    temp -= 10;
                    roman += "X";
                }
                else if (temp - 9 >= 0)
                {
                    temp -= 9;
                    roman += "IX";
                }
                else if (temp - 5 >= 0)
                {
                    temp -= 5;
                    roman += "V";
                }
                else if (temp - 4 >= 0)
                {
                    temp -= 4;
                    roman += "IV";
                }
                else
                {
                    temp -= 1;
                    roman += "I";
                }
            }
            return roman;
        }
    }
}