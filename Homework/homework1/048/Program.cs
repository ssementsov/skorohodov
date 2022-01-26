using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your text: ");
            string usersString = Console.ReadLine();

            int numberSentencies = FindNumberSentencies(usersString);

            string[][] resultArray = TextToSentenciesArray(usersString, numberSentencies);

            Console.WriteLine($"Words, stored in jagged array structure: ");
            JaggedArrayPrinting(resultArray);

            Console.ReadKey();
        }

        static int FindNumberSentencies(string usersString)
        {
            int count = 0;
            for (int i = 0; i < usersString.Length; i++)
            {
                if (usersString[i] == '.')
                {
                    count++;
                }
            }
            return count;
        }

        static string [][]TextToSentenciesArray(string usersString, int numberSentencies)
        {
            string[] usersSentencies = usersString.Split('.');
            string[][] usersSentenciesArray = new string[numberSentencies][];

            for (int i = 0; i < numberSentencies; i++)
            {

                usersSentenciesArray[i] = usersSentencies[i].Split(' ');
            }
            return usersSentenciesArray;

        }

        static void JaggedArrayPrinting (string[][] usersSentenciesArray)
        {
            for (int i = 0; i < usersSentenciesArray.Length; i++)
            {
                Console.Write($"{i} array: ");
                for (int j = 0; j < usersSentenciesArray[i].GetLength(0); j++)
                {
                    Console.Write($"{usersSentenciesArray[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
