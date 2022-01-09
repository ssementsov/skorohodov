using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your array length:           ");
            int usersArrayLength = Convert.ToInt32(Console.ReadLine());
            int [] usersArray = new int[usersArrayLength];

            for (int i = 0; i < usersArrayLength; i++)
            {
                Console.Write($"enter value of {i} element of array: ");
                usersArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(usersArray, (a, b) => b.CompareTo(a));

            int [] extendedUsersArray = new int[usersArrayLength+1];
            usersArray.CopyTo(extendedUsersArray, 0);
            Console.WriteLine($"Your array was descending sorted and extended +1 element!\a\n");

            Console.Write("enter last element of array:  ");
            extendedUsersArray[extendedUsersArray.Length - 1] = Convert.ToInt32(Console.ReadLine());

            foreach (int i in extendedUsersArray)
            {
                Console.Write($"{i}\t");
            }
            Console.ReadKey();
        }
    }
}
