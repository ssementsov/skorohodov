using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            string usersNumber = Console.ReadLine();

            usersNumber = usersNumber.Replace("-", "");
            usersNumber = usersNumber.Replace(".", "");
            usersNumber = usersNumber.Replace(",", "");

            char[] usersNumberArray = usersNumber.ToCharArray();
            Array.Reverse(usersNumberArray);
            string reverseUsersNumber = new string(usersNumberArray);

            bool isUsersNumberPalindrom = (usersNumber == reverseUsersNumber);

            if (isUsersNumberPalindrom)
            {
                Console.WriteLine("Your number is palindrom");
            }
            else
            {
                Console.WriteLine("Your number is not palindrom");
            }
            Console.ReadKey();
        }
    }
}
