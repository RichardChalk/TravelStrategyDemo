using TravelStrategyDemo.Strategies;

namespace TravelStrategyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myTravelPlanner = new TravelPlanner();

            myTravelPlanner.SetTravelStrategy(new Car());
            // myTravelPlanner.SetTravelStrategy(new Plane());
            // myTravelPlanner.SetTravelStrategy(new Bus());
            myTravelPlanner.Drive(1100);

            Console.ReadKey();
        }
    }
}