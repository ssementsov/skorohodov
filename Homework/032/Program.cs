using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите первое число:                          ");
            double usersFirstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("введите второе число:                          ");
            double usersSecondNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write($"введите шаг выведения значений\n" +
                $"(для отделения дробной части используйте ','): ");
            double usersStep = Convert.ToDouble(Console.ReadLine());

            if (usersFirstNumber > usersSecondNumber & usersStep < 0)
            {
                for (double i = usersFirstNumber; i >= usersSecondNumber; i += usersStep)
                {
                    Console.WriteLine(($"\t{i:f1}"));
                }
            }
            else if (usersFirstNumber < usersSecondNumber & usersStep > 0)
            {
                for (double i = usersFirstNumber; i <= usersSecondNumber; i += usersStep)
                {
                    Console.WriteLine(($"\t{i:f1}"));
                }
            }
            else if (usersFirstNumber < usersSecondNumber & usersStep < 0)
            {
                for (double i = usersFirstNumber; i <= usersSecondNumber; i -= usersStep)
                {
                    Console.WriteLine(($"\t{i:f1}"));
                }
            }
            else if (usersFirstNumber > usersSecondNumber & usersStep > 0)
            {
                for (double i = usersFirstNumber; i >= usersSecondNumber; i -= usersStep)
                {
                    Console.WriteLine(($"\t{i:f1}"));
                }
            }
            Console.ReadKey();
        }
    }
}
