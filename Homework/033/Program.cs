using System;

namespace _033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {146, 110, 66, 139, 7, 86, 71, 97, 96,
                160, 138, 67, 145, 133, 183, 185, 23, 124, 177,
                150, 104, 48, 77, 147, 63, 113, 132, 100, 107, 106};
            int tempElementMyArray;
            //ascending buble sort;
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
            Console.WriteLine(" ascending sorted array: ");
            foreach (int i in myArray)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine("press any key to descending sort array");
            Console.ReadKey();
            //descending buble sort;
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length - 1; j++)
                {
                    if (myArray[j] < myArray[j + 1])
                    {
                        tempElementMyArray = myArray[j + 1];
                        myArray[j + 1] = myArray[j];
                        myArray[j] = tempElementMyArray;
                    }
                }
            }
            Console.WriteLine("descending sorted array: ");
            foreach (int i in myArray)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
    }
}
