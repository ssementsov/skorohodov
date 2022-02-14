using System;

namespace _115_Birds.Models
{
    internal class Ostrich : Bird
    {
        public override string Name { get; set; }

        public override Feathers Feathers { get; set; }

        public Ostrich()
        {
            Name = nameof(Ostrich);
            Feathers = new Feathers("black and white");
        }

        public Ostrich(string name, string color)
        {
            Name = name;
            Feathers = new Feathers(color);
        }

        public override void Move() => Console.WriteLine($"{Name} isn't flying.");

        public void Acquaintance() => Console.WriteLine($"{Name} is a ostrich.");
    }
}
