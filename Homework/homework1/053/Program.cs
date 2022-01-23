using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int leastCommonDivisor = LeastCommonDivisor(firstNumber, secondNumber);
            Console.WriteLine($"Least common divisor of {firstNumber} and {secondNumber} is {leastCommonDivisor}");
            Console.ReadKey();
        }
        static int LeastCommonDivisor (int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                int min = Math.Min(a, b);
                int max = Math.Max(a, b);
                return LeastCommonDivisor(max-min, min);
            }
        }
    }
}
