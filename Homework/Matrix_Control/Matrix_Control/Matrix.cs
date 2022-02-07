using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Control
{
    internal class Matrix
    {
        private int[,] MyMatrix { get; set; }

        private int Rows { get; set; }

        private int Columns { get; set; }

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            MyMatrix = new int[rows, columns];
        }

        public int[,] SetRandomMatrix()
        {
            Random r = new Random();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    MyMatrix[i, j] = r.Next(1, 100);
                }
            }

            return MyMatrix;
        }

        public int[,] SetUsersMatrix()
        {

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.WriteLine($"enter [{i}, {j}] element of matrix: ");
                    MyMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            return MyMatrix;
        }

        public void PrintMatrix()
        {
            Console.WriteLine("Matrix: ");

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write($"{MyMatrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public int[,] MatrixMultiplication(int multiplicator)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    MyMatrix[i, j] = MyMatrix[i, j] * multiplicator;
                }
            }

            return MyMatrix;
        }

        public int[,] MatrixMultiplication(int[,] secondMatrix)
        {
            var multiplicatedMatrix = new int[Rows, secondMatrix.GetLength(1)];

            bool isMatrixMultiplicationPossible = Columns == secondMatrix.GetLength(0);

            if (!isMatrixMultiplicationPossible)
            {
                Console.WriteLine("it's impossible to multiplicate your matrix!");
            }

            else if (isMatrixMultiplicationPossible)
            {
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < secondMatrix.GetLength(1); j++)
                    {
                        multiplicatedMatrix[i, j] = 0;

                        for (int k = 0; k < Columns; k++)
                        {
                            multiplicatedMatrix[i, j] += MyMatrix[i, k] * secondMatrix[k, j];
                        }
                    }
                }
            }

            return multiplicatedMatrix;
        }


        public int[,] MatrixAddition(int[,] secondMatrix)
        {
            int indexRowsSecondMatrix = secondMatrix.GetLength(0);
            int indexColumnsSecondMatrix = secondMatrix.GetLength(1);

            bool isMatrixEqual = Rows == indexRowsSecondMatrix &&
                                 Columns == indexColumnsSecondMatrix;

            if (!isMatrixEqual)
            {
                Console.WriteLine("It's impossible to do matrix addition ");
                return MyMatrix;
            }

            else
            {
                Console.WriteLine("Matrix after addition: ");

                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        MyMatrix[i, j] += secondMatrix[i, j];
                    }
                }
            }

            return MyMatrix;
        }
    }
}
