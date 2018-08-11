using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardCalculator
{
    public class MasterCard : CreditCard
    {
        public MasterCard(decimal p_CurrentBalance, int p_Time)
        {
            CurrentBalance = p_CurrentBalance;
            Time = p_Time;
        }

        public override decimal CurrentBalance
        {
            get { return _currentBalance; }
            set { _currentBalance = value; }
        }
        public override int Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public override decimal CalcInterest()
        {
            decimal result = (CurrentBalance * 5 * Time) / 100;
            return result;
        }

    }
}
