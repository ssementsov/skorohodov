using _115_Birds.Models;
using System;

namespace _115_Birds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var perch = new Perch();
            perch.GetInfo();
            Console.WriteLine($"==========\n");

            var canary = new Canary();
            canary.Name = "Chizhyk";
            canary.Wings.Spread();
            canary.Acquaintance();
            canary.Sing();
            canary.Move();
            canary.Breathe();
            canary.GetColor();
            canary.GetCover();
            canary.GetWingsState();
            Console.WriteLine($"==========\n");


            var ostrich = new Ostrich();
            ostrich.GetInfo();
            Console.WriteLine($"==========\n");

            var slope = new Slope();
            slope.Breathe();
            slope.GetWaterType();
            Console.WriteLine($"==========\n");

            
            
           

            Console.ReadKey();
        }
    }
}
