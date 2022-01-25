using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your string: ");
            string usersString = Console.ReadLine();

            string result = MultiplicateDoubleCharacters(usersString);
            Console.WriteLine($"Multiplicated double characters string: {result}");

            Console.ReadKey();
        }
        public static string MultiplicateDoubleCharacters(string usersString)
        {
            for (int i = 0; i < usersString.Length - 1; i++)
            {
                if (usersString[i] == usersString[i + 1])
                {
                    usersString = usersString.Insert(i, $"{usersString[i]}{usersString[i]}");
                    i +=2;
                }
            }

            return usersString;
        }
    }
}
