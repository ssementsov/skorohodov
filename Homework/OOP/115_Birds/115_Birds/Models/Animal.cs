using _115_Birds.Interfaces;
using _115_Birds.Models;
using System;

namespace _115_Birds
{
    public abstract class Animal : IBreather, IMover
    {
        public abstract string Name { get; set; }

        public abstract Skin Skin { get; set; }

       public abstract RespiratoryOrgan RespiratoryOrgan { get; set; }

        public virtual void GetCover() => Console.WriteLine($"{Name} covered with {Skin.Type}.");

        public virtual void Breathe() => Console.WriteLine($"{Name} breathes with {RespiratoryOrgan.Name}.");

        public virtual void Move() => Console.WriteLine($"{Name} can moves.");

        public virtual void GetInfo()
        {
            Breathe();
            Move();
            GetCover();
        }

    }
}