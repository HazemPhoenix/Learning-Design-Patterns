using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    
    // The strategy interface
    interface IWeaponBehavior
    {
        public void UseWeapon();
    }

    // Concrete strategies

    class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Stabs!");
        }
    }

    class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Slashes!");
        }
    }

    class AxeBehavior : IWeaponBehavior
    {
        public void UseWeapon ()
        {
            Console.WriteLine("Chops!");
        }
    }

    class BowAndArrowBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shoots!");
        }
    }

    
    
    

}
