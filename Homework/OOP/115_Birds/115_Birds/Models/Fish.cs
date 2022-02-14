using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _115_Birds.Models
{
    public abstract class Fish : Animal
    {
        public override string Name { get; set; }

        public abstract string WaterType { get; set; }

        public override Skin Skin { get; set; } = new Skin("scales");

        public override RespiratoryOrgan RespiratoryOrgan { get; set; } = new("gills");

        public virtual void GetWaterType() => Console.WriteLine($"{Name} lives in {WaterType}.");

        public override void Move() => Console.WriteLine($"{Name} can swim.");

        public override void GetInfo()
        {
            Breathe();
            Move();
            GetCover();
            GetWaterType();
        }
    }
}
