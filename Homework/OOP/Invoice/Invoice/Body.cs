using System;

namespace Invoice
{
    public class Body
    {
        public Product [] Product { get; set; }

        public int Index { get; set; } = 0;

        public Body()
        {
            Product = new Product[10];
        }

        public void AddProductToBody(Product product)
        {
            bool isInvoiceFull = Index == 10;
            if (!isInvoiceFull)
            {
                Product[Index] = product;
                Index++;
            }
            else if (isInvoiceFull)
            {
                Console.WriteLine("Invoice full! Please, use another invoice!");
            }
        }
        public void PrintBody()
        {
            decimal totalCost = 0;
            Console.WriteLine("\tProducts INFO:");
            Console.WriteLine("=============================================");
            Console.WriteLine($"№  Product\t Quantity\t Price\t Cost ");
            Console.WriteLine("---------------------------------------------");
            for (int i = 0; i < Index; i++)
            {
                totalCost += Product[i].Cost;

                string item = $"{i + 1}. {Product[i].Name}\t{Product[i].Quantity}" +
                              $"\t\t{Product[i].Price}\t{Product[i].Cost} ";

                Console.WriteLine(item);
                Console.WriteLine("_____________________________________________");
            }
            Console.WriteLine($"\n\tTotal cost:    \t\t{totalCost} USD\n");
        }
    }
}