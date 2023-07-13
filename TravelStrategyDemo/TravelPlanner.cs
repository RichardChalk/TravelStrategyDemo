using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelStrategyDemo
{
    public class TravelPlanner
    {
        private TravelStrategy _travelStrategy;

        public void SetTravelStrategy(TravelStrategy travelstrategy)
        {
            _travelStrategy = travelstrategy;
        }

        public void Drive(int km)
        {
            var cost = _travelStrategy.Drive(km);
            Console.WriteLine("This journey will cost: " + cost);
        }
    }
}
