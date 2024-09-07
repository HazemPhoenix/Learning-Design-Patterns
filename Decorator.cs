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
        public new abstract string getDescription(); 

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

    class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage b)
        {
            beverage = b;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }

        public override double cost()
        {
            return 0.20 + beverage.cost(); 
        }
    }

    class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage b)
        {
            beverage = b;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }

        public override double cost()
        {
            return 0.15 + beverage.cost();
        }
    }

    class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage b)
        {
            beverage = b;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }

        public override double cost()
        {
            return 0.10 + beverage.cost();
        }
    }




}
