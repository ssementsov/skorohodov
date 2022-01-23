using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your string: ");
            string usersString = Console.ReadLine();

            int firstSpace = usersString.IndexOf(' ');
            int secondSpace = usersString.LastIndexOf(' ');

            string result = usersString.Substring(firstSpace, secondSpace - firstSpace);
            Console.Write($"Result string: {result}");
            Console.ReadKey();
        }
    }
}
