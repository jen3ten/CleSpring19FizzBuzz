using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is FizzBuzz");
            Console.WriteLine("Enter a number:");
            string userEntry = Console.ReadLine();
            int userEntryAsInt = Convert.ToInt32(userEntry);

            FizzBuzz fizzBuzzer = new FizzBuzz();
            string fizzBuzzResult = fizzBuzzer.Get(userEntryAsInt);
            Console.WriteLine(fizzBuzzResult);
        }
    }
}
