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
            if (IsCheckedOut)
                return string.Format("{0,-40}\n Author: {1,-20} {2,-10} {3}\n", this.Title, this.Author, "unavailable until",DueDate);
            return string.Format("{0,-40}\n Author: {1,-20} {2,-10}\n", this.Title, this.Author, "available");
        }
    }

