using _115_Birds.Models;
using System;

namespace _115_Birds
{
    public class Canary : Bird, ISinger
    {
        public override string Name { get; set; }

        public override Feathers Feathers { get; set; }

        public Canary()
        {
            Name = nameof(Canary);
            Feathers = new Feathers("yellow");
            Wings = new Wings();
        }

        public Canary(string name, string color, string wingsState)
        {
            Name = name;
            Feathers = new Feathers(color);
            Wings = new Wings(wingsState);
        }

        public void Sing() => Console.WriteLine($"{Name} is singing.");

        public void Acquaintance() => Console.WriteLine($"{Name} is a canary.");

        public override void GetWingsState() => Console.WriteLine($"{Name}'s wings {Wings.State}.");

        public override void GetInfo()
        {
            Breathe();
            Move();
            GetCover();
            GetColor();
            Sing();
            GetWingsState();
        }
    }
}