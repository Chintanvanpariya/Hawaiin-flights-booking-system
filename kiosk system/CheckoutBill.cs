using System;
using System.Collections.Generic;
using System.Text;

namespace kiosk_system
{
    public class CheckoutBill
    {
        public static void Checkout(ConsoleScreen _screen, ConsoleKeyPad _keypad)
        {
            bool isnotValid = false;

            do
            {
                _screen.WriteLine("Enter following payment options :");
                _screen.WriteLine("1 : Check");
                _screen.WriteLine("2: Credit card");

                int opt = (int)_keypad.ReadLine();


                if (opt == 1)
                {
                    Check check = new Check();
                    _screen.WriteLine("Enter Bank Number (100000): ");
                    int b_num = (int)_keypad.ReadLine();
                    _screen.WriteLine("Enter Routing Number (100000111) : ");
                    int r_num = (int)_keypad.ReadLine();
                    try
                    {
                        check.BankNumber = b_num;
                        check.RouteNumber = r_num;
                        isnotValid = false;

                    }
                    catch (Exception e)
                    {
                        _screen.WriteLine(e.Message);
                        Console.WriteLine();
                        isnotValid = true;
                    }

                    if (!isnotValid)
                    {

                        try
                        {
                            check.Deduct(Summarize.totalpayableamount);
                        }
                        catch (Exception e)
                        {
                            _screen.WriteLine(e.Message);
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Card card = new Card();

                    try
                    {
                        _screen.WriteLine("Enter Card Number (1000100010001000) : ");
                        long c_num = _keypad.ReadLine();
                        _screen.WriteLine("Enter Expiry Date ( 1130) : ");
                        int e_num = (int)_keypad.ReadLine();
                        _screen.WriteLine("Enter CvV number : ");
                        card.Cvv = (int)_keypad.ReadLine();
                        card.CreditCardNum = c_num;
                        card.ExpDate = e_num;

                        isnotValid = false;
                    }
                    catch (Exception e)
                    {
                        _screen.WriteLine(e.Message);
                        Console.WriteLine();
                        isnotValid = true;
                    }

                    if (!isnotValid)
                    {
                        try
                        {
                            card.Deduct(Summarize.totalpayableamount);
                        }
                        catch (Exception e)
                        {
                            _screen.WriteLine(e.Message);
                            Console.WriteLine();
                        }
                    }

                }
            } while (isnotValid);


            _screen.WriteLine($"Payment successful");
            _screen.WriteLine($"Your available balance is {Payment._amount}");
            Console.WriteLine();

        }
    }
}
