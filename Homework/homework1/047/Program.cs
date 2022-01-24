using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your string: ");
            string usersString = Console.ReadLine();

            Console.Write("enter number of positions to shift string: ");
            int numberShift = int.Parse(Console.ReadLine());

            string result = ShiftString(AscendingSort(usersString), numberShift);

            Console.Write($"Sorted and shifted string: {result}");
            Console.Read();
        }
        public static string AscendingSort(string usersString)
        {
            char[] myArray = usersString.ToCharArray();
            char tempElementMyArray;
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length - 1; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {
                        tempElementMyArray = myArray[j + 1];
                        myArray[j + 1] = myArray[j];
                        myArray[j] = tempElementMyArray;
                    }
                }
            }
            string result = new string(myArray);
            return result;   
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
            string result = new string(charString);
            return result;
        }
    }
}
