using System;
using System.Collections.Generic;
using System.IO;

namespace OOPProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Books> LibBooks = new List<Books>();
            string filePath = @"..\..\..\LibraryLog.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("s");
                Console.WriteLine("Creating library text file");
                List<Books> DefaultBooks = new List<Books>
                {
                    new Books("Dracula", "Bram Stoker"),
                    new Books("Moby Dick", "Herman Melville"),
                    new Books("Frankenstein", "Mary Shelley"),
                    new Books("1984", "George Orwell"),
                    new Books("Lord of the Rings", "J.R.R. Tolkien"),
                    new Books("The Adventures of Huckleberry Finn", "Mark Twain"),
                    new Books("The Iliad", "Homer"),
                    new Books("Charlie and the Chocolate Factory", "Roald Dahl"),
                    new Books("The Count of Monte Cristo", "Alexandre Dumas"),
                    new Books("Tale of Two Cities", "Charles Dickens"),
                    new Books("Art of War", "Sun-Tzu"),
                    new Books("Heart of Darkness", "Joseph Conrad")
                };
                LibBooks = DefaultBooks;

                StreamWriter SW = new StreamWriter(filePath);
                foreach (Books book in DefaultBooks)
                    SW.WriteLine($"{book.Title} ,{book.Author} ,{book.IsCheckedOut},{book.DueDate}");
                SW.Close();
            }
            else {
                StreamReader reader = new StreamReader(filePath);
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    else
                    {
                        string[] values = line.Split(',');
                        string title = values[0];
                        string author = values[1];
                        bool isCheckedOut;
                        if (values[2] == "True")
                            isCheckedOut = true;
                        else
                            isCheckedOut = false;
                        string dueDate = values[3];
                        Books newBook = new Books(title, author, isCheckedOut, dueDate);
                        LibBooks.Add(newBook);
                    }
                }
                reader.Close();
            }

            Library MyLib = new Library(LibBooks);
            MyLib.LibraryMenu();
            
            StreamWriter LibSW = new StreamWriter(filePath);
            foreach (Books book in LibBooks)
                LibSW.WriteLine($"{book.Title} ,{book.Author} ,{book.IsCheckedOut},{book.DueDate}");
            LibSW.Close();

        }
    }
}
