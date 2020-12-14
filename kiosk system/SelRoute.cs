using System;
using System.Collections.Generic;
using System.Text;

namespace kiosk_system
{
    public class SelRoute
    {
        public static void SelectRoute(ConsoleScreen _screen, ConsoleKeyPad _keypad, int menuoption)
        {
            while (true)
            {
                _screen.WriteLine(
               @"Let's add a route, so enter a number that corresponds to one of the following routes:" + "\n" +
               @"1. Ferry goes from Maui to Lanai or vice versa for $30.00 (Adult) $20.00 (Child)" + "\n" +
               @"2. Ferry goes from Maui to Molokai or vice versa for $40.00 (Adult) $20.00 (Child)" + "\n" +
               @"3. Flight goes from Oahu to Maui or vice versa for $80.00" + "\n" +
               @"4. Flight goes from Oahu to Kona or vice versa for $100.00" + "\n" +
               @"5. Flight goes from Oahu to Kauai or vice versa for $50.00"
               );
                try
                {
                    menuoption = (int)_keypad.ReadLine();
                    break;
                }
                catch (Exception e)
                {
                    _screen.WriteLine(e.Message);
                    Console.WriteLine();
                }
            }
            SelMode.SelectMode(_screen, _keypad, menuoption);

        }
    }
}
