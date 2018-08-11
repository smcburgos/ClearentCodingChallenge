using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardCalculator
{
    public class Customer
    {
        public Customer(string p_custName, List<Wallet> p_custWallets)
        {
            CustomerName = p_custName;
            CustomerWallets = p_custWallets;
        }
        private string _customerName;
        private List<Wallet> _custWallets = new List<Wallet>();

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        public List<Wallet> CustomerWallets
        {
            get { return _custWallets; }
            set { _custWallets = value; }
        }
    }
}
