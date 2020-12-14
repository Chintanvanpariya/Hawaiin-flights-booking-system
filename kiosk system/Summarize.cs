using System;
using System.Collections.Generic;
using System.Text;

namespace kiosk_system
{
    public class Summarize
    {
        public static decimal totalpayableamount = 0;

        public static List<String> routeArray = new List<String>();

        public static void Summary(ConsoleScreen _screen, ConsoleKeyPad _keypad, int menuoption, Route route)
        {
            if (menuoption == 1 || menuoption == 2)
            {
                routeArray.Add(((Ferry)route).ToString(route.priceAd));
            }
            else
            {
                routeArray.Add(((Flight)route).ToString(route.priceAd));
            }

            totalpayableamount += route._numOfPass * route.priceAd;

           Console.WriteLine();

            foreach(String strr in routeArray)
            {
                _screen.WriteLine(strr);
            }
            _screen.WriteLine($"The total cost of this transaction is  ${ totalpayableamount } ");
            Console.WriteLine();
        }
    }
}
