using System;
using System.Collections.Generic;
using System.Text;
using OOP_Project.OOPProject;

namespace OOPProject
{
    class Library
    {
        List<Books> LibBooks = new List<Books>();

        public Library(List<Books> LibBooks)
        {
            this.LibBooks = LibBooks;
        }

        public string FindName(List<Books> LibBooks)
        {
            int searchType = Validator.Validator.GetNumber("Type 1 to find book via number associated with it, or 2 to find it using all or part of the title", 1, 2);
            if(searchType == 1)
            {

            }
            
        }
    }
}
