using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Account
    {
        private float pBalance;
        public float balance {
            get {
                return pBalance;
            }
            set {
                if (value > pBalance)
                {
                    throw new Exception("недопустимая операция");
                }
                else if (value < 0)
                {
                    throw new Exception("недостаточно средств");
                }
                else
                {
                    pBalance = value;
                }
            }
        }
        private int pin;

        public bool checkpin(int pin)
        {
            if (this.pin == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Account(float balance, int pin)
        {
           pBalance = balance;
           this.pin = pin;
        }
    }
}