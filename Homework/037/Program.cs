using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037
{
    internal class Program
    {
        static void GetBook(string[,,] array, string searchedBook)
        {
            bool bookFound = false;
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    for (int k = 0; k <= array.GetUpperBound(2); k++)
                    {
                        if (array[i, j, k] == searchedBook)
                        {
                            bookFound = true;
                            Console.WriteLine($"Книга \"{searchedBook}\" расположена на {i} стеллаже, " +
                                              $"на {j} полке, на {k} месте.");
                            break;
                        }
                    } 
                }
            }
            if (!bookFound)
            {
                Console.WriteLine($"Книга \"{searchedBook}\" в библиотеке не найдена");
            } 
        }

            static void Main(string[] args)
            {
                string[,,] myLibrary = new string[5, 10, 10];
                myLibrary[1, 3, 7] = "Книга1";
                myLibrary[2, 1, 8] = "Книга2";
                myLibrary[4, 2, 6] = "Книга3";

                Console.Write("Введите книгу, которую хотите найти: ");
                string searchedBook = Console.ReadLine();
                GetBook(myLibrary, searchedBook);

                Console.ReadKey();
            }
        }
}
