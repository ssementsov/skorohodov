using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public class Invoice
    {
        public DateTime Date { get; set; }

        public string Number { get; set; }

        public string Responsible { get; set; }

        public string Recipient { get; set; }

        public Body Body { get; set; }

        public Invoice()
        {
            Body = new Body();
        }

        public Invoice(string number, DateTime date, string responsible, string recipient)
        {
            Number = number;
            Date = date;
            Responsible = responsible;
            Recipient = recipient;
            Body = new Body();
        }

        public void AddProduct(string productName, decimal productPrice, decimal productQuantity)
        {
            var product = new Product(productName, productPrice, productQuantity);

            Body.AddProductToBody(product);
        }

        public void PrintTitle()
        {
            Console.WriteLine($"\tInvoice № {Number}\n");

            Console.WriteLine($"Date:\t{Date}\n");

            Console.WriteLine($"From \t\t{Responsible}");
            Console.WriteLine($"To   \t\t{Recipient}");
            Console.WriteLine("=============================================");
        }

        public void PrintFooter()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine($"Responsible: \t_________ \t{Responsible}");
            Console.WriteLine($"              \tsignature");
            Console.WriteLine();

            Console.WriteLine($"Recipient:   \t_________ \t{Recipient}");
            Console.WriteLine($"              \tsignature");
        }

        public void PrintInvoice()
        {
            PrintTitle();
            Body.PrintBody();
            PrintFooter();
        }
    }
}
