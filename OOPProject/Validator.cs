using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    class Validator
    {
        //gets valid input from user for searching by title or author as well as giving them a choice to return to main menu.
        public static int ValidateSelectBy() {
            int selection;
            do
            {
                Console.WriteLine("Enter 1 to search by title, 2 to search by author or 0 to return to main menu");
                try
                {
                    selection = int.Parse(Console.ReadLine());
                    if (selection == 1)
                        return selection;
                    else if (selection == 2)
                        return selection;
                    else if (selection == 0)
                        return selection;
                    Console.WriteLine("Must enter 1 , 2 or 0 ");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Must Enter a number");
                }
            } while (true);
        }

        //gets a valid index position from the user as as well as giving them a choice to return to main menu.
        public static int ValidateIndex(int ListLength)
        {
            do
            {
                try
                {
                    Console.WriteLine("Enter number of book or enter 0 to return to main menu");
                    int BookIndex = int.Parse(Console.ReadLine());
                    if (BookIndex <= ListLength) 
                        if(BookIndex >=0 )
                            return BookIndex-1;
                    Console.WriteLine($"must enter a number between 1 and {ListLength}");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Must enter number between 1 and {ListLength}");
                }

            } while (true);
        }
    }
}
