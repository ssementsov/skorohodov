using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements Fibonacci: ");
            int numberOfElements = int.Parse(Console.ReadLine());

            int firstNumber = 0, secondNumber = 1, nextNumber;
            if (numberOfElements < 2)
            {
                Console.Write("Please enter a number greater than one: ");
            }

            else
            {
                Console.Write($"{firstNumber}\t{secondNumber}\t");

                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + secondNumber;
                    Console.Write($"{nextNumber} \t");
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }

            }

            Console.WriteLine();
            Console.Write($" {numberOfElements} element of Fibonacci is {secondNumber}");

            Console.ReadKey();
        }
    }
}
