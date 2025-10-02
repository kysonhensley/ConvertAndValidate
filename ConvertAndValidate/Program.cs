using System;

namespace ConvertAndValidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int convertedNumber;
            bool continueProgram = true;

            do
            {

                Console.Write("Please enter a number: ");
                userInput = Console.ReadLine();

                if (ValidateAndConvert(userInput, out convertedNumber) == true)
                {
                    Console.WriteLine($"You typed: {convertedNumber} and it has successfully been converted to an integer.");
                }
                else
                {
                    Console.WriteLine($"You typed: {userInput} and it has not been converted to an integer, please try again.");
                }

                Console.WriteLine("type exit to quit");

                if (userInput.ToLower() == "exit")
                {
                    continueProgram = false;
                }
            } while (continueProgram == true);
        }

        static bool ValidateAndConvert(string userInput, out int convertedNumber)
        {
            return int.TryParse(userInput, out convertedNumber);
        }
    }
}