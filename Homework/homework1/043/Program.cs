using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your text: ");
            string usersString = Console.ReadLine();

            Console.Write("Enter chars to remove from text: ");
            string charsToRemove = Console.ReadLine();
            
            var result = ReverseString(RemoveChars(usersString, charsToRemove));
            Console.WriteLine($"Your text after remove chars and reverse: {result}");

            Console.ReadKey();
        }
        public static string RemoveChars(string usersString, string charsToRemove)
        {
            char[] arrayCharsToRemove = charsToRemove.ToCharArray();

            foreach (char c in arrayCharsToRemove)
            {
                usersString = usersString.Replace(c.ToString(), "");
            }

                return usersString;
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
