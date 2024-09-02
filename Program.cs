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



            Character king = new King();
            Character queen = new Queen();
            Character knight = new Knight();
            Character troll = new Troll();

            king.Fight();
            queen.Fight();
            knight.Fight();
            troll.Fight();
            Console.WriteLine("---------------------");
            knight.setWeaponBehavior(new BowAndArrowBehavior());
            knight.Fight();


        }
    }
}
