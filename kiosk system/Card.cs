using System;
using System.Collections.Generic;
using System.Text;

namespace kiosk_system
{
    class Card : Payment
    {
        private long _creditcardnum;
        private int _expdate;
        private int _cvv;

        public long CreditCardNum
        {
            get
            {
                return _creditcardnum;
            }
            set
            {
                if (value != 1000100010001000)
                {
                    throw new ArgumentException("Error : credit card number should be 1000100010001000");
                }
                else
                {
                    _creditcardnum = value;
                }
            }
        }

        public int ExpDate
        {
            get
            {
                return _expdate;
            }
            set
            {
                if (value != 1130)
                {
                    throw new ArgumentException("Error : Expirate date  should be 1130");
                }
                else
                {
                    _expdate = value;
                }
            }
        }

        public int Cvv 
        { 
            get 
            { 
                return _cvv;
            } 
            set 
            { 
                _cvv = value; 
            } 
        }

        public override void Deduct(decimal billamount)
        {
            if (_amount - billamount < 0)
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
