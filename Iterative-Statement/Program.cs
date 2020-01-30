using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //This try catch will insure input is in the proper format
            try
            {
                Console.WriteLine("Please enter integer value from 1 to 100");
                // This variable will collect data from user input
                string input = Console.ReadLine();
                // This variable will store the input and parse it as an input
                int inputValue = int.Parse(input);

                if ((inputValue > 0) && (inputValue <= 100))

                {

                    // This is the for-loop; It will count to the inputed number
                    for (int i = 1; i <= inputValue; i++)
                    {
                        Console.WriteLine("You have entered " + inputValue.ToString() + ". This is the current integer value in the loop:" + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    // Pause the program and await the user to press a key to end the program
                    Console.ReadKey(true);

                }
                else
                    Console.WriteLine("Input must be an integer between 0 and 100");
            }
            catch
            {
                Console.WriteLine("Answer must be an integer between 1 and 100");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }
        }
    }
}
