using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106
{
    public class Book
    {
        public string BooksTitle { get; set; }
        public string BookAuthor { get; set; }

        public Book()
        {
            BooksTitle = "C# in Depth.";
            BookAuthor = "Jon Skeet";
        }

        public Book(string BooksTitle, string BookAuthor)
        {
            this.BooksTitle = BooksTitle;
            this.BookAuthor = BookAuthor;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Book \"{BooksTitle}\" was written by {BookAuthor}.");
        }
    }
}
