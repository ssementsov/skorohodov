using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106
{
    public class MyBook : Book
    {
        public int BookPrice { get; set; }

        public MyBook()
        {
            BookPrice = 35;
        }

        public MyBook(int BookPrice)
        {
            this.BookPrice = BookPrice;
        }

        public MyBook(string BooksTitle, string BookAuthor, int BookPrice)
           : base(BooksTitle, BookAuthor)
        {
            this.BookPrice = BookPrice;
        }

        public override void Print()
        {
            Console.WriteLine($"Price of \"{BooksTitle}\" is {BookPrice} USD.");
        }
    }
}
