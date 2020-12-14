using System;
using System.Collections.Generic;
using System.Text;

namespace kiosk_system
{
    public  class Flight : Route
    {
        public string ToString(decimal price)
        {
            return "Route Summary - Flight goes from " + _fromIsland + " To " + _toIsland + " for " + _numOfPass + " X $" + price + " = " + (price * _numOfPass) ;
        }

    }
}
