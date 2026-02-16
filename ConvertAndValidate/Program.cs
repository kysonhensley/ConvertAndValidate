namespace ConvertAndValidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create bool variable to track if user wants to quit program 
            bool userQuits = false;
            string userInput = "";

            Console.WriteLine("Please enter an input to try and convert to 32 bit int or type 'quit' to exit program.");
            //while loop that continues to ask user for input until they type 'quit' to exit program
            while (!userQuits)
            {
                userInput = Console.ReadLine();
                //check if user wants to quit program
                if (userInput.ToLower() == "quit")
                {
                    userQuits = true;
                    break;
                }
                else
                {
                    userQuits = false;
                }
                //call ConvertStringToInt method and pass the user input as an argument, display the result if successful or error message if not and prompt user to try again or type 'quit' to exit program
                if (TryConvertStringToInt(userInput, out int result))
                {
                    Console.WriteLine($"The conversion was sucessful {userInput} --> {result}");
                }
            }
            Console.Read();
        }

        //create method that when called will convert a string to an int and return result, if the string cannot be converted then return error message
        static bool TryConvertStringToInt(string input, out int result)
        {
            //try to convert the string to an int, if successful return true and the result
            if (int.TryParse(input, out result))
            {
                return true;
            }
            //if the string cannot be converted to an int, return false and display error message
            else
            {
                Console.WriteLine($"{input} cannot be converted to a 32 bit integer. Please try again or type 'quit' to exit program:");
                return false;
            }
        }
    }
}
