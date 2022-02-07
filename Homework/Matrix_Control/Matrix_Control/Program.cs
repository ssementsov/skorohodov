using System;

namespace Matrix_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your rows number:     ");
            int usersRows = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter your columns number:  ");
            int usersColumns = Convert.ToInt32(Console.ReadLine());

            var firstMatrix = new Matrix(usersRows, usersColumns);
            firstMatrix.SetRandomMatrix();
            firstMatrix.PrintMatrix();

            Console.WriteLine("==========");


            Console.Write("enter multiplicator: ");
            int usersMultiplicator = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Matrix after multiplication: ");
            firstMatrix.MatrixMultiplication(usersMultiplicator);
            firstMatrix.PrintMatrix();

            Console.WriteLine("===========");

            Console.WriteLine("Matrix after multiplication to another matrix: ");

            int[,] secondMatrix = { { 23, 34, 56 },
                                    { 45, 76, 12 } };

            int[,] resultMatrix = firstMatrix.MatrixMultiplication(secondMatrix);
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    Console.Write($"{resultMatrix[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}