using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036
{
    internal class Program
    {
        static int[,] GetRandomArray(int rowUsersArray, int columnUsersArray)
        {
            var randomArray = new int[rowUsersArray, columnUsersArray];
            Random r = new Random();
            for (int i = 0; i < rowUsersArray; i++)
            {
                for (int j = 0; j < columnUsersArray; j++)
                {
                    randomArray[i, j] = r.Next(100);
                }
            }
            return randomArray;
        }
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        static int[,] MultiplicateArray(int[,] firstArray, int[,] secondArray)
        {
            var multiplicatedArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    multiplicatedArray[i, j] = 0;

                    for (int k = 0; k < firstArray.GetLength(0); k++)
                    {
                        multiplicatedArray[i, j] += firstArray[i, k] * secondArray[k, j];
                    }
                }
            }
            return multiplicatedArray;
        }
        static void Main(string[] args)
        {
            Console.Write("enter value \"rows\" in first array:      ");
            int rowFirstArray = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter value \"columns\" in first array:   ");
            int columnFirstArray = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter value \"rows\" in second array:     ");
            int rowSecondArray = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter value \"columns\" in second array:  ");
            int columnSecondArray = Convert.ToInt32(Console.ReadLine());

            bool isMatrixMultiplicationPossible = columnFirstArray == rowSecondArray;

            if (!isMatrixMultiplicationPossible)
            {
                Console.WriteLine("it's impossible to multiplicate your arrays!");
            }
            else if (isMatrixMultiplicationPossible)
            {
                int[,] firstArray = GetRandomArray(rowFirstArray, columnFirstArray);
                Console.WriteLine("\nfirst array: ");
                PrintArray(firstArray);

                int[,] secondArray = GetRandomArray(rowSecondArray, columnSecondArray);
                Console.WriteLine("\nsecond array: ");
                PrintArray(secondArray);

                int[,] multiplicatedArray = MultiplicateArray(firstArray, secondArray);
                Console.WriteLine("\nmultiplicated array: ");
                PrintArray(multiplicatedArray);
            }
            Console.ReadKey();
        }
    }
}
