using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelStrategyDemo.Strategies
{
    public class Car : TravelStrategy
    {
        public Car()
        {
            _kilometerCost= 25;
        }
        public override decimal Drive(int km)
        {
            return km * _kilometerCost;
        }
    }
}
