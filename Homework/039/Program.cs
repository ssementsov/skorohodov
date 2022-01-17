using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039
{
    internal class Program
    {
        static void PrintResult(int a, int b, int c)=>Console.WriteLine("Result is " + (a + b + c));
        static void PrintResult(ref int a, ref int b, ref int c)=>Console.WriteLine("Result is " + (a - b - c));
        static void PrintResult(int a, int b)=>Console.WriteLine("Result is " + Math.Pow(a, b));
        static void PrintResult(int a, int b, int c, out string result )
        {
            result = a.ToString() + "+" + b.ToString() + "+" + c.ToString();
            Console.WriteLine("Result is " + result);
        }
            static void Main(string[] args)
        {
            int a = 3;
            int b = 2;
            int c = 1;
            
            PrintResult(a, b, c);
            PrintResult(ref a, ref b, ref c);
            PrintResult(a, b);
            PrintResult(a,b,c, out string result);

            Console.ReadKey();
        }
    }
}
