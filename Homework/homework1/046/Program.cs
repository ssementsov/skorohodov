using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your string: ");
            string usersString = Console.ReadLine();

            string result = ReverseString(UnuqueChars(usersString));

            Console.WriteLine($"Your unique reversed string: {result}");

            Console.ReadKey();
        }
        public static string UnuqueChars(string usersString)
        {
            var uniqueCharsList = usersString.Distinct().ToList();
            var result = string.Empty;

            foreach (var item in uniqueCharsList)
            {
                result += item;
            }

            return result;
        }
        public static string ReverseString(string usersString)
        {
            var result = string.Empty;

            for (int i = usersString.Length - 1; i >= 0; i--)
            {
                result += usersString[i];
            }

            return result;
        }

    }
}
