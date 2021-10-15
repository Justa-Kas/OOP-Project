using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Books
    {
        //properties
        public string Title { get; set; }
        public string Author { get; set; }

    public Books(string title, string author)
    {
        this.Title = title;
        this.Author = author;
    }
        public override string ToString()
        {
            return $"Title: {Title} Author: {Author}";
        }
    }

