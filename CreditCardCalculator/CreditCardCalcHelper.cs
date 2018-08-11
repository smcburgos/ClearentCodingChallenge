using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardCalculator
{
    public class CreditCardCalcHelper
    {
        // tally up interest for all customers,wallets, and credit cards passed into helper
        public decimal CalculateTotalInterest(List<Customer> p_cust)
        {
            decimal totalInterest = 0;
            foreach(Customer thisCust in p_cust)
            {
                foreach(Wallet thisWallet in thisCust.CustomerWallets)
                {
                    foreach(CreditCard thisCC in thisWallet.CustomerCreditCards)
                    {
                        totalInterest = totalInterest + thisCC.CalcInterest();
                    }
                }
            }
            return totalInterest;
        }
    }
}
