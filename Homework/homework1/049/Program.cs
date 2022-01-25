using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to find its factorial: ");
            int usersNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factorial = " + Factorial((ulong)usersNumber));
            Console.ReadKey();
        }
        static ulong Factorial(ulong number)
        {
            if (number == 1) return 1;

            return number * Factorial(number - 1);
        }
        
    }
}
