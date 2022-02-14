using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _115_Birds.Models
{
    public class Slope : Fish
    {
        public override string Name => nameof(Slope);

        public override string WaterType { get; set; } = "sea water";

        public Slope()
        {
            Name = nameof(Slope);
        }
        public Slope(string name)
        {
            Name = name;
        }

        public void Acquaintance() => Console.WriteLine($"{Name} is a slope.");

    }
}
