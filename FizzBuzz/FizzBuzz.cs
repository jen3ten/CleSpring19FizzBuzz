using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Get(int num)
        {
            string fizzBuzzResult = "";

            if (IsMultipleOf3(num))
            {
                fizzBuzzResult = "Fizz";
            }

            if (IsMultipleOf5(num))
            {
                fizzBuzzResult = fizzBuzzResult + "Buzz";
            }

            if (fizzBuzzResult.Equals(""))
            {
                fizzBuzzResult = num.ToString();
            }

            return fizzBuzzResult;
        }

        private bool IsMultipleOf3(int numberToCheck)
        {
            return numberToCheck % 3 == 0;
        }

        private bool IsMultipleOf5(int numberToCheck)
        {
            return numberToCheck % 5 == 0;
        }

    }
}
