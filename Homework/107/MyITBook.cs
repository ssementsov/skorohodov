using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106
{
    public class MyITBook : MyBook
    {
        public string Theme { get; set; }

        public MyITBook()
        {
            Theme = "C# coding";
        }

        public MyITBook(int BookPrice, string Theme)
        {
            this.BookPrice = BookPrice;
            this.Theme = Theme;
        }

        public MyITBook(string BooksTitle, string BookAuthor, int BookPrice, string Theme)
           : base(BooksTitle, BookAuthor, BookPrice)
        {
            this.Theme = Theme;
        }

        public override void Print()
        {
            Console.WriteLine($"Book \"{BooksTitle}\" by {BookAuthor} is to study {Theme}."); ;
        }
    }
}
