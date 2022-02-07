using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun myGun = new Gun();

            myGun.Fire();
            myGun.Fire();
            myGun.ReloadWeapon();
            myGun.ReloadWeapon();

            Console.WriteLine($"Rest cartridges in clip is {myGun.CartridgesInClip}");
            Console.WriteLine($"Rest total cartridges is {myGun.TotalCartridges}");

            Console.ReadKey();
        }
    }
}
