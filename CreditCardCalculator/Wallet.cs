using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardCalculator
{
    public class Wallet
    {
        public Wallet(List<CreditCard> p_custCreditCards)
        {
            CustomerCreditCards = p_custCreditCards;
        }
        private List<CreditCard> _custCreditCards = new List<CreditCard>();

        public List<CreditCard> CustomerCreditCards
        {
            get { return _custCreditCards; }
            set { _custCreditCards = value; }
        }
    }
}
