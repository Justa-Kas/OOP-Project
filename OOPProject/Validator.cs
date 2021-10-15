using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    class Validator
    {
        public static int GetNumber(string whatIsItFor)
        {
            int result = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine(whatIsItFor);
                   result = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a valid input");
                }
            }
            return result;
        }
        public static double GetNumber(double min, double max)
        {
            double result = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine($"Please enter a number between {min} and {max}");
                    result = double.Parse(Console.ReadLine());
                    if (result >= min && result <= max)
                    {
                        break;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a valid input");
                }
            }
            return result;
        }

        public static bool ValidateWord(string userInput,string option1, string option2)
        {
            while (true) {
                Console.WriteLine($"Enter either {option1} or {option2}.");
                if (userInput.ToLower() == option1)
                {
                    return true;
                }
                else if (userInput.ToLower() == option2)
                {
                    return false;
                }
                else
                {
                    Console.Write("Not a valid input, Please try again. ");
                }
            }
        }

        public static bool GetContinue()
        {
            bool result = true;
            while (true)
            {
                Console.WriteLine("Would you like to keep running the program? y/yes/n/no");
                string choice = Console.ReadLine().ToLower().Trim();
                if(choice == "y")
                {
                    result = true;
                    break;
                }else if(choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid input. Try again");
                }
            }
            return result;
        }

        public static bool GetContinue(string didntExcept)
        {
            bool result = true;
            while (true)
            {
                Console.WriteLine("Would you like to keep running the program? y/n");
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "y"|| choice =="yes")
                {
                    result = true;
                    break;
                }
                else if (choice == "n"||choice =="no")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine(didntExcept);
                }
            }
            return result;
        }
    }
}
