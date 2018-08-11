using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardCalculator
{
    public abstract class CreditCard
    {
        protected decimal _currentBalance;
        protected int _time;

        public abstract decimal CurrentBalance
        {
            get;
            set;
        }

        public abstract int Time
        {
            get;
            set;
        }

        public abstract decimal CalcInterest();


    }
}
