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
            Console.Write("enter your number: ");
            int usersNumber = Convert.ToInt32(Console.ReadLine());
            int restUsersNumber;
            int reverseUsersNumber = 0;
            int tempUsersNumber = usersNumber;

            while (usersNumber > 0)
            {
                restUsersNumber = usersNumber % 10;
                reverseUsersNumber = (reverseUsersNumber * 10) + restUsersNumber;
                usersNumber /= 10;
            }
            Console.WriteLine($"reverse users number: {reverseUsersNumber}");

            bool isUsersNumberPalindrome = tempUsersNumber == reverseUsersNumber;
            string usersNumberIsPalindrome = "Your number is palindrome!";
            string usersNumberIsNotPalindrome = "Your number  is not palindrome!";

            string result = isUsersNumberPalindrome ? usersNumberIsPalindrome : usersNumberIsNotPalindrome;
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
