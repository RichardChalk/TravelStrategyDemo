using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelStrategyDemo.Strategies
{
    public class Plane : TravelStrategy
    {
        public Plane()
        {
            _kilometerCost = 50; // Expensive!
        }
        public override decimal Drive(int km)
        {
            if (km > 1000)
                _kilometerCost = 15;
            return km * _kilometerCost;
        }
    }
}
