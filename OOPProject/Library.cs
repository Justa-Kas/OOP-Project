using System;
using System.Collections.Generic;
using System.Text;

namespace OOPProject
{
    class Library
    {
        List<Books> BookList = new List<Books>();
    
        
        
        
        public void display() {
            for (int i = 0; i < BookList.Count; i++)
            {
                Console.WriteLine(BookList[i].ToString());
            }    
        }

    }
}
