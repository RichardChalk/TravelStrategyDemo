using TravelStrategyDemo.Strategies;

namespace TravelStrategyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myTravelPlanner = new TravelPlanner();

            myTravelPlanner.SetTravelStrategy(new Car());
            myTravelPlanner.Drive(1100);

            Console.ReadKey();
        }
    }
}