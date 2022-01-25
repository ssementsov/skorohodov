using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to find its factorial: ");
            int usersNumber = Convert.ToInt32(Console.ReadLine());

            int i, result = 1;
            for (i = usersNumber; i > 0; i--)
            {
                result *= i;
            }
            Console.WriteLine($"Factorial = {result}"); ;
            Console.ReadKey();
        }
    }
}
