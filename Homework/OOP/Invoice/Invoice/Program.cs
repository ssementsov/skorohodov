using System;

namespace Invoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Invoice();

            invoice.Date = new DateTime(2022, 01, 25);
            invoice.Number = "245-A";
            invoice.Responsible = "Ivanov";
            invoice.Recipient = "Petrov";

            invoice.AddProduct("Banana", 4.7m, 5);
            invoice.AddProduct("Computer", 1000, 1);
            invoice.AddProduct("MobilePhone", 100, 1);
            invoice.AddProduct("Pineapple", 11.3m, 4);

            invoice.PrintInvoice();

            Console.ReadKey();

        }
    }
}
