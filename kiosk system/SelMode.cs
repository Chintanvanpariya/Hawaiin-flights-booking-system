using System;
using System.Collections.Generic;
using System.Text;

namespace kiosk_system
{
    public class SelMode
    {
        public static void SelectMode(ConsoleScreen _screen, ConsoleKeyPad _keypad, int menuoption)
        {

            if (menuoption == 1)
            {
                _screen.WriteLine("Enter 1 if you want to go from Maui to Lanai; otherwise, you want to go from Lanai to Maui");
                int inp = (int)_keypad.ReadLine();
                Ferry1 f1 = new Ferry1();

                if (inp == 1)
                {
                    f1._fromIsland = "Maui";
                    f1._toIsland = "Lanai";
                }
                else
                {
                    f1._fromIsland = "Lanai";
                    f1._toIsland = "Maui";
                }
                _screen.WriteLine("Enter 1 if you want to add number of child passengers; otherwise for adult persons");
                inp = (int)_keypad.ReadLine();
                if (inp == 1)
                    f1.priceAd = 20M;
                else
                    f1.priceAd = 30M;

                _screen.WriteLine("Enter number of passengers");
                f1._numOfPass = (int)_keypad.ReadLine();
                Summarize.Summary(_screen, _keypad, menuoption, f1);
            }

            else if (menuoption == 2)
            {
                _screen.WriteLine("Enter 1 if you want to go from Maui to Molokai;  otherwise, you want to go from Molokai to Maui");
                int inp = (int)_keypad.ReadLine();
                Ferry1 f2 = new Ferry1();

                if (inp == 1)
                {
                    f2._fromIsland = "Maui";
                    f2._toIsland = "Molokai";
                }
                else
                {
                    f2._fromIsland = "Molokai";
                    f2._toIsland = "Maui";
                }
                _screen.WriteLine("Enter 1 if you want to add number of child passengers; otherwise for adult persons");
                inp = (int)_keypad.ReadLine();
                if (inp == 1)
                    f2.priceAd = 40M;
                else
                    f2.priceAd = 20M;

                _screen.WriteLine("Enter number of passengers");
                f2._numOfPass = (int)_keypad.ReadLine();
                Summarize.Summary(_screen, _keypad, menuoption, f2);
            }

            else if (menuoption == 3)
            {
                _screen.WriteLine("Enter 1 if you want to go from Oahu to Maui;  otherwise, you want to go from Maui to Oahu");
                int inp = (int)_keypad.ReadLine();
                Flight1 f3 = new Flight1();
                f3.priceAd = 80M;

                if (inp == 1)
                {
                    f3._fromIsland = "Oahu";
                    f3._toIsland = "Maui";
                }
                else
                {
                    f3._fromIsland = "Maui";
                    f3._toIsland = "Oahu";
                }

                _screen.WriteLine("Enter number of passengers");
                f3._numOfPass = (int)_keypad.ReadLine();
                Summarize.Summary(_screen, _keypad, menuoption, f3);
            }

            else if (menuoption == 4)
            {
                _screen.WriteLine("Enter 1 if you want to go from Oahu to Kona ; otherwise, you want to go from Kona to Oahu");
                int inp = (int)_keypad.ReadLine();
                Flight2 f4 = new Flight2();
                f4.priceAd = 100M;

                if (inp == 1)
                {
                    f4._fromIsland = "Oahu";
                    f4._toIsland = "Kona";
                }
                else
                {
                    f4._fromIsland = "Kona";
                    f4._toIsland = "Oahu";
                }

                _screen.WriteLine("Enter number of passengers");
                f4._numOfPass = (int)_keypad.ReadLine();
                Summarize.Summary(_screen, _keypad, menuoption, f4);
            }

            else if (menuoption == 5)
            {
                _screen.WriteLine("Enter 1 if you want to go from Oahu to Kauai; otherwise, you want to go from Kauai to Oahu");
                int inp = (int)_keypad.ReadLine();
                Flight3 f5 = new Flight3();
                f5.priceAd = 50M;

                if (inp == 1)
                {
                    f5._fromIsland = "Oahu";
                    f5._toIsland = "Kauai";
                }
                else
                {
                    f5._fromIsland = "Oahu";
                    f5._toIsland = "Honolulu";
                }

                _screen.WriteLine("Enter number of passengers");
                f5._numOfPass = (int)_keypad.ReadLine();
                Summarize.Summary(_screen, _keypad, menuoption, f5);

            }
        }

    }
}
