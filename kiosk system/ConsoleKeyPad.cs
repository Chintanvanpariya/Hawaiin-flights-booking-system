using System;
using System.Collections.Generic;
using System.Text;

namespace kiosk_system
{
    public class ConsoleKeyPad : IKeyPad
    {
        public long ReadLine()
        {
            string str = Console.ReadLine();
            long val;
            if( ! long.TryParse(str, out val))
            {
                throw new ArgumentException("enter numeric inputs ");
            }
            if( val < 0)
            {
                throw new ArgumentException("enter positive inputs only ");
            }
            return val;
        }

       
    }
}
