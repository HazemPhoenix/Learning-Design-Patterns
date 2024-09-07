namespace DesignPatterns
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Duck WoodenDuck = new WoodenDuck();
            //Duck RubberDuck = new RubberDuck();
            //Duck MallardDuck = new MallardDuck();
            //Duck RobotDuck = new RobotDuck(); 


            //WoodenDuck.PerformQuack();
            //WoodenDuck.PerformFly();

            //RubberDuck.PerformQuack();
            //RubberDuck.PerformFly();

            //MallardDuck.PerformQuack();
            //MallardDuck.PerformFly();

            //RobotDuck.PerformQuack();
            //RobotDuck.PerformFly();

            //Console.WriteLine("--------------------");

            //MallardDuck.setFlyBehavior(new RoboticFly());
            //MallardDuck.setQuackBehavior(new Squeak());
            //MallardDuck.PerformFly();
            //MallardDuck.PerformQuack();

            //DuckCall roboticDuckMimicker = new DuckCall(new RoboticQuack());
            //roboticDuckMimicker.Call(); 



            //Character king = new King();
            //Character queen = new Queen();
            //Character knight = new Knight();
            //Character troll = new Troll();

            //king.Fight();
            //queen.Fight();
            //knight.Fight();
            //troll.Fight();
            //Console.WriteLine("---------------------");
            //knight.setWeaponBehavior(new BowAndArrowBehavior());
            //knight.Fight();

            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription()
                    + " $" +beverage.cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.getDescription()
                     + " $" + beverage2.cost());
            
            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.getDescription()
                    + " $" + beverage3.cost());


        }
    }
}
