namespace DesignPatterns
{
    internal class Program
    {

        interface IFlyBehavior
        {
            public void Fly();
        }

        interface IQuackBehavior
        {
            public void Quack();
        }

        class FlyWithWings : IFlyBehavior
        {
            public void Fly()
            {
                Console.WriteLine("Flying with wings!");
            }
        }

        class FlyNoWay : IFlyBehavior
        {
            public void Fly()
            {
                Console.WriteLine("Tries to fly but can't :( ");
            }
        }

        class NormalQuack : IQuackBehavior
        {
            public void Quack ()
            {
                Console.WriteLine("Quacks!");
            }
        }
        class Squeak : IQuackBehavior
        {
            public void Quack ()
            {
                Console.WriteLine("Squeaks!");
            }
        }
        class MuteQuack : IQuackBehavior
        {
            public void Quack ()
            {
                Console.WriteLine("Quacks in silence!");
            }
        }
        
        class RoboticQuack : IQuackBehavior
        {
            public void Quack ()
            {
                Console.WriteLine("Quacks in a robotic voice!");
            }
        }

        class RoboticFly : IFlyBehavior
        {
            public void Fly ()
            {
                Console.WriteLine("Flies using artificial wings!");
            }
        }

        class Duck
        {
            public IQuackBehavior quackBehavior;
            public IFlyBehavior flyBehavior;

            public void PerformQuack()
            {
                quackBehavior.Quack();
            }
            public void PerformFly()
            {
                flyBehavior.Fly();
            }

            public void setQuackBehavior(IQuackBehavior qb)
            {
                quackBehavior = qb;
            }

            public void setFlyBehavior(IFlyBehavior fb)
            {
                flyBehavior = fb;
            }

        }


        class MallardDuck : Duck
        {
            public MallardDuck ()
            {
                quackBehavior = new NormalQuack();
                flyBehavior = new FlyWithWings();
                
            }
        }

        class RubberDuck : Duck
        {
            public RubberDuck ()
            {
                quackBehavior = new Squeak();
                flyBehavior = new FlyNoWay();
            }
        }

        class WoodenDuck : Duck
        {
            public WoodenDuck ()
            {
                quackBehavior = new MuteQuack();
                flyBehavior = new FlyNoWay();
            }
        }

        class RobotDuck : Duck
        {
            public RobotDuck ()
            {
                quackBehavior = new RoboticQuack();
                flyBehavior = new RoboticFly();
            }
        }

        

        //A duck call is a device that hunters use to [mimic] the sound of ducks, 
        //so it should NOT inherit from the duck class, as it itself is not a duck
        class DuckCall
        {
            IQuackBehavior quackBehavior;

            public DuckCall()
            {
                quackBehavior = new NormalQuack();
            }
            public DuckCall(IQuackBehavior qb)
            {
                quackBehavior = qb;
            }

            public void setQuackBehavior(IQuackBehavior qb)
            {
                quackBehavior = qb;
            }

            public void Call()
            {
                quackBehavior.Quack();
            }

        }




        static void Main(string[] args)
        {
            Duck WoodenDuck = new WoodenDuck();
            Duck RubberDuck = new RubberDuck();
            Duck MallardDuck = new MallardDuck();
            Duck RobotDuck = new RobotDuck(); 


            WoodenDuck.PerformQuack();
            WoodenDuck.PerformFly();

            RubberDuck.PerformQuack();
            RubberDuck.PerformFly();

            MallardDuck.PerformQuack();
            MallardDuck.PerformFly();

            RobotDuck.PerformQuack();
            RobotDuck.PerformFly();

            Console.WriteLine("--------------------");

            MallardDuck.setFlyBehavior(new RoboticFly());
            MallardDuck.setQuackBehavior(new Squeak());
            MallardDuck.PerformFly();
            MallardDuck.PerformQuack();

            DuckCall roboticDuckMimicker = new DuckCall(new RoboticQuack());
            roboticDuckMimicker.Call(); 
        }
    }
}
