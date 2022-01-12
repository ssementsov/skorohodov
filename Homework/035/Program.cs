using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035
{
    internal class Program
    {
        static int[,]GetUsersArray (int rowUsersArray,int columnUsersArray)
        {
            var usersArray = new int[rowUsersArray, columnUsersArray];
            for (int i = 0; i < rowUsersArray; i++)
            {
                for (int j = 0; j < columnUsersArray; j++)
                {
                    Console.Write($"enter value of [{i}, {j}] element of array: ");
                    usersArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return usersArray;
        }
        static int [,]MultiplicateArray(int [,] firstArray, int[,]secondArray)
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
        static void PrintArray(int [,]array)
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
        static void Main(string[] args)
        {
            Console.Write("enter value \"rows\" in first array:      ");
            int rowFirstUsersArray = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter value \"columns\" in first array:   ");
            int columnFirstUsersArray = Convert.ToInt32(Console.ReadLine());
          
            Console.Write("enter value \"rows\" in second array:     ");
            int rowSecondUsersArray = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter value \"columns\" in second array:  ");
            int columnSecondUsersArray = Convert.ToInt32(Console.ReadLine());
                       
            bool isMatrixMultiplicationPossible = columnFirstUsersArray == rowSecondUsersArray;
            
            if (!isMatrixMultiplicationPossible)
            {
                Console.WriteLine("it's impossible to multiplicate your arrays!");
            }
            
            else if (isMatrixMultiplicationPossible)
            {
                Console.WriteLine("please, enter values of elements of first array!");
                int[,] firstArray = GetUsersArray(rowFirstUsersArray, columnFirstUsersArray);

                Console.WriteLine("please, enter values of elements of second array!");
                int[,] secondArray = GetUsersArray(rowSecondUsersArray, columnSecondUsersArray);
                
               int[,] multiplicatedArray = MultiplicateArray(firstArray, secondArray);

                Console.WriteLine("\nfirst array: ");
                PrintArray(firstArray);

                Console.WriteLine("\nsecond array: ");
                PrintArray(secondArray);

                Console.WriteLine("\nmultiplicated array: ");
                PrintArray(multiplicatedArray);
            }
            
            Console.ReadKey();
        }
    }
}
