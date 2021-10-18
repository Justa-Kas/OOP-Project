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
        public bool IsCheckedOut { get; set; }
        public string DueDate { get; set; }

        public Books(string title, string author)
        {
        this.Title = title;
        this.Author = author;
        this.IsCheckedOut = false;
        this.DueDate = "";
        }


        public override string ToString()
        {
            if(IsCheckedOut)
                return $"{Title} by {Author} unavailable";
            return $"{Title} by {Author} available";
        }
    }

