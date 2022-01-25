using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements Fibonacci: ");
            int numberOfElements = int.Parse(Console.ReadLine());

            int numberFibonacci = Fibonacci(numberOfElements);
            Console.Write($" {numberOfElements} element of Fibonacci is {numberFibonacci}");
            Console.ReadKey();
        }
        static int Fibonacci(int number)
        {
            if (number == 0|| number == 1)
            {
                return number;
            }

            else
            {
                return number = Fibonacci(number-1)+Fibonacci(number-2);
            }

        }
    }
}
