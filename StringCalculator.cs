using System;

namespace ramona_first_code
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers == "")
                return 0;

            if (numbers.Length > 1)
            {
                var separatedNumbers = numbers.Split(",");
                var number1 = separatedNumbers[0];
                var number2 = separatedNumbers[1];
                return Convert.ToInt32(number1) + Convert.ToInt32(number2);
            }
            return Convert.ToInt32(numbers);
        }
    }
}