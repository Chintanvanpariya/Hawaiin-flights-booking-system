using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace kiosk_system
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("               Welcome to Hawaiin inter-islands Travel !!           " + "\n");

            ConsoleScreen _screen = new ConsoleScreen();
            ConsoleKeyPad _keypad = new ConsoleKeyPad();
            int menuoption = 0;

            //first time get route route
            SelRoute.SelectRoute(_screen, _keypad, menuoption);

            nxtStep(_screen, _keypad, menuoption);
        }

        public static void nxtStep(ConsoleScreen _screen, ConsoleKeyPad _keypad,int  menuoption)
        {
            _screen.WriteLine("Enter 1 if you want pay;otherwise other input to add more routes");
            int inp = (int)_keypad.ReadLine();
            if (inp == 1)
            {
                //route flow to payment section
                CheckoutBill.Checkout(_screen, _keypad);
            }
            else
            {
                //get and add another route in array
                SelRoute.SelectRoute(_screen, _keypad, 0);
                nxtStep(_screen, _keypad, 0);
            }

        }

    }
}

