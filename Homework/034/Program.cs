using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034
{
    internal class Program
    {
        static int ReverseMethod(ref int usersNumber)
        {
            int restUsersNumber;
            int reverseUsersNumber = 0;
            while (usersNumber > 0)
            {
                restUsersNumber = usersNumber % 10;
                reverseUsersNumber = (reverseUsersNumber * 10) + restUsersNumber;
                usersNumber /= 10;
            }
            return reverseUsersNumber;
        }
        static void Main(string[] args)
        {
            int[] usersArray = {108, 91, 122, 114, 62, 182, 110, 73, 167, 67, 24, 74, 116, 120, 42, 
                171, 52, 46, 23, 31, 146, 169, 161, 178, 90, 44, 142, 133, 184, 115};
            Console.WriteLine("array BEFORE reverse: ");
            foreach (int user in usersArray)
            {
                Console.Write($"{user} ");
            }
            Console.WriteLine("\n array AFTER reverse: ");
            for (int i = 0; i < usersArray.Length; i++)
            {
                usersArray[i] =  ReverseMethod (ref usersArray[i]);
                Console.Write($"{usersArray[i]} ");
            }
            Console.Read();
        }
    }
}
