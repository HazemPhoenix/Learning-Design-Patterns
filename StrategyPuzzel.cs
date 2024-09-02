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
        public string UseWeapon();
    }

    // Concrete strategies

    class KnifeBehavior : IWeaponBehavior
    {
        public string UseWeapon()
        {
            return "stabs!";
        }
    }

    class SwordBehavior : IWeaponBehavior
    {
        public string UseWeapon()
        {
            return "slashes!";
        }
    }

    class AxeBehavior : IWeaponBehavior
    {
        public string UseWeapon ()
        {
            return "chops!";
        }
    }

    class BowAndArrowBehavior : IWeaponBehavior
    {
        public string UseWeapon()
        {
            return "shoots!";
        }
    }

    
    // Context 
    abstract class Character
    {
        public IWeaponBehavior weaponBehavior;

        public abstract void Fight();

        public void setWeaponBehavior(IWeaponBehavior wb)
        {
            weaponBehavior = wb;
        }

    }

    class King : Character
    {
        public King()
        {
            weaponBehavior = new SwordBehavior();
        }
        public King(IWeaponBehavior wb)
        {
            weaponBehavior = wb; 
        }

        public override void Fight()
        {
            Console.WriteLine($"The king {weaponBehavior.UseWeapon()}");
        }
    }

    class Queen : Character
    {
        public Queen()
        {
            weaponBehavior = new KnifeBehavior();
        }
        public Queen(IWeaponBehavior wb)
        {
            weaponBehavior = wb;
        }

        public override void Fight()
        {
            Console.WriteLine($"The Queen {weaponBehavior.UseWeapon()}");
        }
    }

    class Knight : Character
    {
        public Knight()
        {
            weaponBehavior = new SwordBehavior();
        }
        public Knight(IWeaponBehavior wb)
        {
            weaponBehavior = wb;
        }

        public override void Fight()
        {
            Console.WriteLine($"The Knight {weaponBehavior.UseWeapon()}");
        }
    }

    class Troll : Character
    {
        public Troll()
        {
            weaponBehavior = new AxeBehavior();
        }
        public Troll(IWeaponBehavior wb)
        {
            weaponBehavior = wb;
        }

        public override void Fight()
        {
            Console.WriteLine($"The Troll {weaponBehavior.UseWeapon()}");
        }
    }
}
