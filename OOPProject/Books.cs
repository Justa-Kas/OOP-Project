using System;
using System.Collections.Generic;
using System.Text;

namespace OOPProject
{
    class Books
    {
        //properties
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsCheckedOut { get; set; }

        //constructor
        public Books(string title, string author, bool ischeckedout)
        {
            this.Title = title;
            this.Author = author;
            this.IsCheckedOut = ischeckedout;
        }
    }
}
