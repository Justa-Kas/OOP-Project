using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OOPProject
{
    class Library
    {
        //creates book list for the library object.
        List<Books> LibBooks = new List<Books>();

        //constructor that takes a Books list as a parameter.
        public Library(List<Books> LibBooks)
        {
            this.LibBooks = LibBooks;
        }


        //displays books and their index in order.
        public void displayBooks(List<Books> selectedBooks)
        {
            for (int i = 0; i < selectedBooks.Count; i++)
                Console.WriteLine(String.Format("{0,-3} {1,-3 }", i + 1 + ".", selectedBooks[i].ToString()));
        }

        //returns a new list matching author search criteria.
        public List<Books> ListByAuthor(string input)
        {
            List<Books> SelectedList = new List<Books>();
            List<string> keyWords = input.Split(' ').ToList();
            foreach (Books book in LibBooks)
            {
                foreach (string word in keyWords)
                {
                    if (book.Author.ToLower().Contains(word))
                    {
                        SelectedList.Add(book);
                        break;
                    }
                }
            }
            return SelectedList;
        }

        //returns a new list matching title search criteria.
        public List<Books> ListByTitle(string input)
        {
            List<Books> SelectedList = new List<Books>();
            List<string> keyWords = input.Split(' ').ToList();
            foreach (Books book in LibBooks)
            {
                foreach (string word in keyWords)
                {
                    if (book.Title.ToLower().Contains(word))
                    {
                        SelectedList.Add(book);
                        break;
                    }
                }
            }
            return SelectedList;
        }



        //changes IsCheckedOut to true.
        public void checkOutBook()
        {
            int selection = Validator.ValidateSelectBy();

            //calls search by title method.
            if (selection == 1)
            {
                Console.WriteLine("Enter title or words from title");
                string searchTitle = Console.ReadLine().ToLower();
                List<Books> SelectedList = ListByTitle(searchTitle);

                //tells the user if there are no books matching search criteria.
                if (SelectedList.Count == 0)
                {
                    Console.WriteLine("No books matching search criteria.");
                    return;
                }

                //displays books matching search criteria.
                displayBooks(SelectedList);
                int BookIndex = Validator.ValidateIndex(SelectedList.Count);

                //returns to main menu
                if (BookIndex == -1)
                    return;

                //finds the book selected from the temporary search list then changes the IsCheckedOut and DueDate variables of the main list book object.
                foreach (Books book in LibBooks)
                {
                    if (SelectedList[BookIndex].Equals(book))
                    {

                        if (!book.IsCheckedOut)
                        {
                            book.IsCheckedOut = true;
                            book.DueDate = DateTime.Now.AddDays(14).ToString();
                            Console.WriteLine($"you have checked out {book.ToString()} your due date is {book.DueDate}");
                            return;
                        }

                        //tells the user if they already checked out book.
                        else
                        {
                            Console.WriteLine("Book Already Checked out");
                            return;
                        }
                    }
                }
            }

            //calls search by author method.
            if (selection == 2)
            {
                Console.WriteLine("Enter first or last name of author");
                string searchTitle = Console.ReadLine().ToLower();
                List<Books> SelectedList = ListByAuthor(searchTitle);

                //tells the user if there are no books matching search criteria.
                if (SelectedList.Count == 0)
                {
                    Console.WriteLine("No books matching search criteria.");
                    return;
                }

                //displays books matching search criteria.
                displayBooks(SelectedList);
                int BookIndex = Validator.ValidateIndex(SelectedList.Count);

                //finds the book in the main Books list then checks it out.
                foreach (Books book in LibBooks)
                {
                    if (SelectedList[BookIndex].Equals(book))
                    {
                        if (!book.IsCheckedOut)
                        {
                            book.IsCheckedOut = true;
                            book.DueDate = DateTime.Now.AddDays(14).ToString();
                            Console.WriteLine($"you have checked out {book.ToString()} your due date is {book.DueDate}");
                            break;
                        }
                        Console.WriteLine("Book already checked out");
                        return;
                    }
                }
            }
        }

        //changes IsCheckedOut to true.
        public void returnBook()
        {
            int selection = Validator.ValidateSelectBy();

            //calls search by title method.
            if (selection == 1)
            {
                Console.WriteLine("Enter title or words from title");
                string searchTitle = Console.ReadLine().ToLower();
                List<Books> SelectedList = ListByTitle(searchTitle);

                //tells the user if there are no books matching search criteria.
                if (SelectedList.Count == 0)
                {
                    Console.WriteLine("No books matching search criteria.");
                    return;
                }

                //displays books matching search criteria.
                displayBooks(SelectedList);
                int BookIndex = Validator.ValidateIndex(SelectedList.Count);

                //returns to main menu
                if (BookIndex == -1)
                    return;

                //finds the book in the main Books list then returns it.
                foreach (Books book in LibBooks)
                {
                    if (SelectedList[BookIndex].Equals(book))
                    {
                        if (book.IsCheckedOut)
                        {
                            book.IsCheckedOut = false;
                            book.DueDate = DateTime.Now.AddDays(14).ToString();
                            Console.WriteLine($"you have returned {book.Title}.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Book Already Checked out");
                            break;
                        }
                    }
                }
            }
            if (selection == 2)
            {
                Console.WriteLine("Enter first or last name of author");
                string searchTitle = Console.ReadLine().ToLower();
                List<Books> SelectedList = ListByAuthor(searchTitle);

                //tells the user if there are no books matching search criteria.
                if (SelectedList.Count == 0)
                {
                    Console.WriteLine("No books matching search criteria.");
                    return;
                }

                //displays books matching search criteria.
                displayBooks(SelectedList);
                int BookIndex = Validator.ValidateIndex(SelectedList.Count);

                //returns to main menu
                if (BookIndex == -1)
                    return;

                //finds the book in the main Books list then returns it.
                foreach (Books book in LibBooks)
                {
                    if (SelectedList[BookIndex].Equals(book))
                    {
                        if (book.IsCheckedOut)
                        {
                            book.IsCheckedOut = false;
                            book.DueDate = DateTime.Now.AddDays(14).ToString();
                            Console.WriteLine($"you have returned {book.Title}.");
                            break;
                        }
                        Console.WriteLine("Book not checked out");
                        return;
                    }
                }
            }
        }

        //Method for using the library object.
        public void LibraryMenu()
        {
            int option = 0;

            //displays options to the user.
            do
            {
                Console.WriteLine("Welcome to the Library!");
                Console.WriteLine("1. Display all books");
                Console.WriteLine("2. Checkout a book");
                Console.WriteLine("3. Return a book");
                Console.WriteLine("4. Exit Library");
                option = int.Parse(Console.ReadLine());

                //checks for which options the user selected.
                if (option == 1)
                    displayBooks(LibBooks);
                else if (option == 2)
                    checkOutBook();
                else if (option == 3)
                    returnBook();
                else
                    break;
            } while (option != 4);

            //Tells the user good bye.
            Console.WriteLine("Good bye.");
        }
    }
}


