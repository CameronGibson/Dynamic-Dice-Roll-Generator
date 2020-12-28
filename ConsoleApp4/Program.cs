using System;
using System.Threading;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            //Define some needed variables.
            Random rand = new Random();
            string lcvAsString;
            string inputAsString;
            int lcv;
            int input;
            int counter = 0;
            int index = 0;
            bool repeat = true;

            while (repeat)
            {
                //Get the amount of dice rolls and intialize the array.
                Console.WriteLine("Enter the number of dice you would like to roll.");
                inputAsString = Console.ReadLine();
                while (inputAsString.Length > 3 || inputAsString.Equals(string.Empty))
                {
                    Console.WriteLine("Error: Please enter a valid number");
                    inputAsString = Console.ReadLine();
                }
                input = Convert.ToInt32(inputAsString);
                int possibleOutcomes = (input * 6) - (input - 1);
                int[] rolls = new int[possibleOutcomes];

                //Get a loop control variable from the user.
                Console.WriteLine("How many times would you like to roll?");
                lcvAsString = Console.ReadLine();
                while (lcvAsString.Length > 10 || lcvAsString.Equals(string.Empty))
                {
                    Console.WriteLine("Error: Please enter a valid number");
                    lcvAsString = Console.ReadLine();
                }
                lcv = Convert.ToInt32(lcvAsString);

                //Get all possible outcomes.
                while (counter != lcv)
                {
                    index = 0;
                    counter++;
                    for (int i = 0; i < input; i++)
                    {
                        index += rand.Next(1, 7);
                    }
                    rolls[index - input]++;
                }

                //print the outcome of all dice rolls.
                Console.WriteLine("Outcomes:");
                for (int i = 0; i < rolls.Length; i++)
                {
                    Console.WriteLine("Rolled {0}, {1} times.", i + input, rolls[i]);
                }

                Console.WriteLine("Would you like to run this again? Y/N");
                string repeatInput = Console.ReadLine();
                while(!repeatInput.Equals("Y") && !repeatInput.Equals("N"))
                {
                    Console.WriteLine("Input not recognized, try again.");
                    repeatInput = Console.ReadLine();
                }

                if(repeatInput == "N")
                {
                    repeat = false;
                    Console.WriteLine("Goodbye and tata for now.");
                }
            }
        }
    }
}
