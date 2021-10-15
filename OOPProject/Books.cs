using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project.OOPProject
{
    class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"Title: {Title} Author: {Author}";
        }
    }
}
