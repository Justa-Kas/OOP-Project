using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OOPProject
{
    class Library
    {
        public static DateTime Now { get; }
        List<Books> LibBooks = new List<Books>();

        public Library(List<Books> LibBooks)
        {
            this.LibBooks = LibBooks;
        }
        

        public void displayBooks(List<Books> selectedBooks) {
            for (int i = 0; i < selectedBooks.Count; i++)
                Console.WriteLine(String.Format("{0,-3} {1,-3 }", i+1+".", selectedBooks[i].ToString()));
        }

        public List<Books> ListByAuthor(string input) {
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




        public void checkOutBook() {
            
            int selection = Validator.ValidateSelectBy();
            if (selection == 1) {
                Console.WriteLine("Enter title or words from title");
                string searchTitle = Console.ReadLine().ToLower();
                List<Books> SelectedList = ListByTitle(searchTitle);
                if (SelectedList.Count == 0)
                {
                    Console.WriteLine("No books matching search criteria.");
                    return;
                }
                displayBooks(SelectedList);
                int BookIndex = Validator.ValidateIndex(SelectedList.Count);
                if (BookIndex==-1) {
                    return;
                }
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
                        else
                        {
                            Console.WriteLine("Book Already Checked out");
                            return;
                        }
                    }
                }
            }
            if (selection==2) 
            {
                Console.WriteLine("Enter first or last name of author");
                string searchTitle = Console.ReadLine().ToLower();
                List<Books> SelectedList = ListByAuthor(searchTitle);
                if (SelectedList.Count == 0) 
                {
                    Console.WriteLine("No books matching search criteria.");
                    return;
                }
                displayBooks(SelectedList);
                int BookIndex = Validator.ValidateIndex(SelectedList.Count);
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
        public void returnBook() {
            int selection = Validator.ValidateSelectBy();

            if (selection == 1)
            {

                Console.WriteLine("Enter title or words from title");
                string searchTitle = Console.ReadLine().ToLower();
                List<Books> SelectedList = ListByTitle(searchTitle);
                if (SelectedList.Count == 0)
                {
                    Console.WriteLine("No books matching search criteria.");
                    return;
                }
                displayBooks(SelectedList);
                int BookIndex = Validator.ValidateIndex(SelectedList.Count);
                if (BookIndex==-1)
                    return;        
                foreach (Books book in LibBooks)
                {
                    if (SelectedList[BookIndex].Equals(book))
                    {
                        if (book.IsCheckedOut)
                        {
                            book.IsCheckedOut = false;
                            book.DueDate = DateTime.Now.AddDays(14).ToString();
                            Console.WriteLine($"you have returned {book.Title} ");
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
                if (SelectedList.Count == 0)
                {
                    Console.WriteLine("No books matching search criteria.");
                    return;
                }
                displayBooks(SelectedList);
                int BookIndex = Validator.ValidateIndex(SelectedList.Count);
                if (BookIndex == -1)
                    return;
                foreach (Books book in LibBooks)
                {
                    if (SelectedList[BookIndex].Equals(book))
                    {
                        if (book.IsCheckedOut)
                        {
                            book.IsCheckedOut = false;
                            book.DueDate = DateTime.Now.AddDays(14).ToString();
                            Console.WriteLine($"you have returned {book.Title} your due date is {book.DueDate}");
                            break;
                        }
                        Console.WriteLine("Book not checked out");
                        return;
                    }
                }
            }
        }


        public void LibraryMenu() {
            int option=0;
            do {
                Console.WriteLine("Welcome to the book store!");
                Console.WriteLine("1. Display all books");
                Console.WriteLine("2. Checkout a book");
                Console.WriteLine("3. Return a book");
                Console.WriteLine("4. Exit Library");
                option = int.Parse(Console.ReadLine());


                if (option == 1)
                    displayBooks(LibBooks);
                else if (option == 2)
                    checkOutBook();
                else if (option == 3)
                    returnBook();
                else
                    break;


            } while (option != 4 );
            Console.WriteLine("Good bye.");
        }
    }
}


