using System;

namespace _115_Birds
{
    public class Feathers
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Feathers()
        {
            Color = "yellow";
            Name = "feathers";
        }

        public Feathers(string color)
        {
            Color = color;
            Name = "feathers";
        }

        public void GetColor() => Console.WriteLine($"Feather's color is {Color}.");
    }
}