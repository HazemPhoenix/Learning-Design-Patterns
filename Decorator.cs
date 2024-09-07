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
        public abstract double cost(); 

    }

}
