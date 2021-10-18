using System;
using System.Collections.Generic;

namespace OOPProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Books> LibBooks = new List<Books>
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
            Library myLib = new Library(LibBooks);

            myLib.LibraryMenu();




        }




    }
}
