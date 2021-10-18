using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    class Validator
    {
        public static int ValidateSelectBy() {
            int selection;
            do
            {
                Console.WriteLine("Enter 1 to search by title or 2 to search by author");
                try
                {
                    selection = int.Parse(Console.ReadLine());
                    if (selection == 1)
                        return selection;
                    else if (selection == 2)
                        return selection;
                    Console.WriteLine("Must enter 1 or 2 ");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Must Enter a number");
                }
            } while (true);
        }

        public static int ValidateIndex(int ListLength)
        {
            do
            {
                try
                {
                    Console.WriteLine("Enter number of book");
                    int BookIndex = int.Parse(Console.ReadLine());
                    if (BookIndex <= ListLength) {
                        if(BookIndex >=1 ){
                            return BookIndex-1;
                        }
                    }
                    Console.WriteLine($"must enter a number between 1 and {ListLength}");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Must enter number between 1 and {ListLength}");
                }

            } while (true);
        }

        public static string validateAgain() {
            do {
                string selection = Console.ReadLine();
                if (selection == "y")
                    return selection;
                else if (selection == "n")
                    return selection;
                Console.WriteLine("Must enter y or n ");
            } while (true);
        }
    }


}
