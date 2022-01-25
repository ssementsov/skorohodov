using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your string: ");
            string usersString = Console.ReadLine();

            Console.Write("enter number of positions to shift string: ");
            int numberShift = int.Parse(Console.ReadLine());

            string result = ReverseString(ShiftString(usersString, numberShift));
            Console.Write($"Shifted and reversed string: {result}");
            Console.Read();
        }
        public static string ShiftString(string usersString, int numberShift)
        {
            char[] charString = usersString.ToCharArray();
            for (int i = 0; i < numberShift; i++)
            {
                char temp;
                for (int j = 0; j < charString.Length - 1; j++)
                {
                    temp = charString[0];
                    charString[0] = charString[j + 1];
                    charString[j + 1] = temp;
                }
            }
                string result = new string (charString);
                return result;
        }
        public static string ReverseString(string usersString)
        {
            var result = string.Empty;

            for (int i = usersString.Length-1; i >= 0; i--)
            {
                result += usersString[i];
            }

            return result;
        }
    }
}
