using System;
using System.Collections.Generic;
using System.Text;

namespace kiosk_system
{
    public abstract class Payment
    {
        public static decimal _amount = 500M;
        public abstract void Deduct(decimal value);
    }
}
