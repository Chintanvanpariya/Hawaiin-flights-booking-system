using System;
using System.Collections.Generic;
using System.Text;

namespace kiosk_system
{
    class Check : Payment
    {
        private long _banknum;

        public long BankNumber
        {
            get
            {
                return _banknum;
            }
            set
            {
                if (value != 100000)
                {
                    throw new ArgumentException("Error : Bank num should be 100000");
                }
                else
                {
                    _banknum = value;
                }
            }
        }

        private long _routnum;
        public long RouteNumber
        {
            get
            {
                return _routnum;
            }
            set
            {
                if (value != 100000111)
                {
                    throw new ArgumentException("Error : Route num should be 100001111");
                }
                else
                {
                    _routnum = value;
                }
            }
        }

        public override void Deduct(decimal billamount)
        {

            if ( _amount - billamount < 0)
            {
                throw new ArgumentException("Payable amount exceeds your balance");
            }
            else
            {
                _amount = _amount - billamount;
            }

        }
    }
}
