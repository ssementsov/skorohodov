using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _115_Birds.Models
{
    public class Perch : Fish
    {
        public override string Name => nameof(Perch);

        public override string WaterType { get; set; } = "fresh water";

        public Perch()
        {
            Name = nameof(Perch);
        }
        public Perch(string name)
        {
            Name = name;
        }

        public void Acquaintance() => Console.WriteLine($"{Name} is a perch.");

    }
}
