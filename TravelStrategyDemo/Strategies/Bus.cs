using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelStrategyDemo.Strategies
{
    public class Bus : TravelStrategy
    {
        public Bus()
        {
            _kilometerCost = 15;
        }
        public override decimal Drive(int km)
        {
            return (km * _kilometerCost) * .9m;
        }
    }
}
