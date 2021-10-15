using System;
using System.Collections.Generic;

namespace OOPProject
{
    class Program
    {
        static void Main(string[] args)
        {
                
        }

        List<Books> LibBooks = new List<Books>
        {
            new Books("Dracula", "Bram Stoker", false),
            new Books("Moby Dick", "Herman Melville", false),
            new Books("Frankenstein", "Mary Shelley", false),
            new Books("1984", "George Orwell", false),
            new Books("Lord of the Rings", "J.R.R. Tolkien", false),
            new Books("The Adventures of Huckleberry Finn", "Mark Twain", false),
            new Books("The Iliad", "Homer", false),
            new Books("Charlie and the Chocolate Factory", "Roald Dahl", false),
            new Books("The Count of Monte Cristo", "Alexandre Dumas", false),
            new Books("Tale of Two Cities", "Charles Dickens", false),
            new Books("Art of War", "Sun-Tzu", false),
            new Books("Heart of Darkness", "Joseph Conrad", false)
        };
    }
}
