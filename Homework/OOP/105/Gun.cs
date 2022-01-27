using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105
{
    internal class Gun
    {
        public int TotalCartridges { get; set; }

        public int CartridgesInClip { get; set; }

        public const int ClipCapacity = 3;

        public Gun()
        {
            TotalCartridges = 10;
            CartridgesInClip = 2;
        }

        public int Fire()
        {
            Console.WriteLine("Press any key to shoot");
            Console.ReadKey();

            bool isClipEmpty = CartridgesInClip == 0;

            if (!isClipEmpty)
            {
                Console.WriteLine($"Shot fired successfully!\a");
                CartridgesInClip--;
            }

            else if (isClipEmpty || TotalCartridges > 0)
            {
                Console.WriteLine("Reload your weapon!");
            }

            else if (isClipEmpty || TotalCartridges == 0)
            {
                Console.WriteLine("Ammo ran out!");
            }

            return CartridgesInClip;
        }

        public int ReloadWeapon()
        {
            Console.WriteLine("Press any key to reload your weapon!");
            Console.ReadKey();

            int i;
            bool isFullClip = CartridgesInClip == ClipCapacity;
            bool outOfAmmo = TotalCartridges == 0;

            if (isFullClip)
            {
                Console.WriteLine($"Reloading weapons is not required! There are {CartridgesInClip} rounds per clip");
            }

             else if (CartridgesInClip < ClipCapacity || !outOfAmmo)
            {
                for (i = CartridgesInClip; i < ClipCapacity; i++)
                {
                    CartridgesInClip++;
                    TotalCartridges--;

                    if (outOfAmmo)
                    {
                        Console.WriteLine("You're out of ammo!");
                        break;
                    }
                }

                Console.WriteLine($"Weapon reloading successful! There are {CartridgesInClip} rounds per clip");
            }

            else if (outOfAmmo)
            {
                Console.WriteLine("You're out of ammo!");
            }

            return CartridgesInClip;
            return TotalCartridges;
        }
    }
}