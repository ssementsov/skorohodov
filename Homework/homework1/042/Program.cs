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

            string result = CopySpaceToSpace(usersString);
            Console.Write($"Result string: {result}");

            Console.ReadKey();
        }
        static string CopySpaceToSpace(string usersString)
        {
            int firstSpace = 0, secondSpace = 0;

            for (int i = 0; i < usersString.Length; i++)
            {
                if (usersString[i] == ' ')
                {
                    if (firstSpace == 0)
                    {
                        firstSpace = i;
                    }

                    else
                    {
                        secondSpace = i;
                    }

                }
            }

            string result = string.Empty;

            for (int i = firstSpace+1; i < secondSpace; i++)
            {
                result += usersString[i];
            }

            return result;
        }
    }
}
