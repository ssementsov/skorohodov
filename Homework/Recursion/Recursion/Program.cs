using System;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 10;
            PrintDiffer(a, b);

            Console.WriteLine();

            int c = 20;
            int d = 10;
            PrintDiffer(c, d);

            Console.ReadKey();
        }
        public static void PrintDiffer(int a, int b)
        {
            if (a == b)
            {
                Console.Write($"{a} ");
            }

            else if (a < b)
            {
                Console.Write($"{a} ");
                a++;
                PrintDiffer(a, b);
            }

            else if (a > b)
            {
                Console.Write($"{a} ");
                a--;
                PrintDiffer(a, b);
            }
        }
    }
}

