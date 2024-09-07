using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    abstract class Beverage
    {
        public string description = "Unknown Beverage"; 
        public string getDescription() { return description; }
        public abstract double cost();

    }

    
    abstract class CondimentDecorator : Beverage
    {
        public abstract string getDescription(); 

    }

    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House blend coffee";
        }

        public override double cost()
        {
            return 0.89;
        }
    }

    class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double cost()
        {
            return 1.99;
        }
    }

    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark roast coffee";
        }

        public override double cost()
        {
            return 0.99;
        }
    }

     class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf coffee";
        }

        public override double cost()
        {
            return 1.05;
        }
    }




}
