using _115_Birds.Models;
using System;

namespace _115_Birds
{
    public abstract class Bird : Animal
    {
        public override string Name { get; set; }

        public Wings Wings { get; set; } = new Wings();

        public abstract Feathers Feathers { get; set; }

        public override Skin Skin { get; set; } = new("feather");

        public override RespiratoryOrgan RespiratoryOrgan { get; set; } = new("lungs");

        public override void Move() => Console.WriteLine($"{Name} can fly.");

        public virtual void GetColor() => Console.WriteLine($"{Name} is {Feathers.Color}.");

        public virtual void GetWingsState() => Console.WriteLine($"{Name}'s wings {Wings.State}.");

        public override void GetInfo()
        {
            Breathe();
            Move();
            GetCover();
            GetColor();
            GetWingsState();
        }
    }
}