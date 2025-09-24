using System.ComponentModel.Design;

namespace ConvertAndValidate
{
    internal class Program
    {

        /*
        []Take two arguments: a string value to be converted, and an out integer variable to store the result.
        []Return a boolean indicating if the conversion was successful.
        []If successful, update the out integer variable with the converted value.
        []If not, do not update the integer variable.
        */

        static bool ConvertAndValidate(string convertThis,  ref int toThisNumber)
        {
            try
            {
                //try to convert and assign ByRef variable
                toThisNumber = int.Parse(convertThis);
                //success!
                return true;
            }
            catch (Exception)
            {
                //fail
                return false;
            }
            
           
        }

        static void Main(string[] args)
        {
            int theNumber = 0;
            string userData = "w";

            if (ConvertAndValidate(userData, ref theNumber) == true)
            {
                Console.WriteLine($"{theNumber} + 5 = {theNumber + 5}");
            }
            else
            {
                Console.WriteLine($"{userData} is not a number.");
            }


                //Pause
                Console.Read();
        }
    }
}
