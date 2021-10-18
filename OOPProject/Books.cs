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

        public Books(string title, string author, bool IsCheckedOut, string DueDate)
        {
            this.Title = title;
            this.Author = author;
            this.IsCheckedOut = IsCheckedOut;
            this.DueDate = DueDate;
        }

        public Books()
        {
            this.Title ="";
            this.Author ="";
            this.IsCheckedOut = false;
            this.DueDate = "";
        }




    public override string ToString()
        {
            if (IsCheckedOut)
                return string.Format("{0,-40} by {1,-20} {2,-10} {3}", this.Title, this.Author, "unavailable until",DueDate);
            return string.Format("{0,-40} by {1,-20} {2,-10}", this.Title, this.Author, "available");
        }
    }

