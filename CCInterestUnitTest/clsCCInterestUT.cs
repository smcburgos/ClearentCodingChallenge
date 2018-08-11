using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CreditCardCalculator;

namespace CCInterestUnitTest
{
    [TestFixture]
    public class clsCCInterestUT
    {
        [Test]
        public void OnePerson_OneWallet_ThreeCards()
        {
            decimal decBalance = 100;
            int intTime = 1;
            // create 3 credit cards
            List<CreditCard> PersonCreditCards = new List<CreditCard>();
            PersonCreditCards.Add(new Visa(decBalance, intTime));
            PersonCreditCards.Add(new Discover(decBalance, intTime));
            PersonCreditCards.Add(new MasterCard(decBalance, intTime));
            // create one wallet
            List<Wallet> PersonWallet = new List<Wallet>();
            PersonWallet.Add(new Wallet(PersonCreditCards));
            // create one customer
            List<Customer> PersonList = new List<Customer>();
            PersonList.Add(new Customer("Janet Wilson", PersonWallet));
            
            // calculate total interest combined
            CreditCardCalcHelper ccHelper = new CreditCardCalcHelper();
            Assert.AreEqual(16, ccHelper.CalculateTotalInterest(PersonList));
        }

        [Test]
        public void OnePerson_TwoWallet()
        {
            decimal decBalance = 100;
            int intTime = 1;
            // create 2 credit cards
            List<CreditCard> PersonWalletOneCCs = new List<CreditCard>();
            PersonWalletOneCCs.Add(new Visa(decBalance, intTime));
            PersonWalletOneCCs.Add(new Discover(decBalance, intTime));
            // create one more credit card
            List<CreditCard> PersonWalletTwoCCs = new List<CreditCard>();
            PersonWalletTwoCCs.Add(new MasterCard(decBalance, intTime));
            // create two wallets
            List<Wallet> PersonWallets = new List<Wallet>();
            PersonWallets.Add(new Wallet(PersonWalletOneCCs));
            PersonWallets.Add(new Wallet(PersonWalletTwoCCs));
            // create one customer
            List<Customer> PersonList = new List<Customer>();
            PersonList.Add(new Customer("Terry Kelner", PersonWallets));

            // calculate total interest combined
            CreditCardCalcHelper ccHelper = new CreditCardCalcHelper();
            Assert.AreEqual(16, ccHelper.CalculateTotalInterest(PersonList));
        }

        [Test]
        public void TwoPeople_OneWalletEach()
        {
            decimal decBalance = 100;
            int intTime = 1;
            // create 2 credit cards for person 1, wallet 1
            List<CreditCard> PersonWalletOneCCs = new List<CreditCard>();
            PersonWalletOneCCs.Add(new MasterCard(decBalance, intTime));
            PersonWalletOneCCs.Add(new Visa(decBalance, intTime));
            // create 2 credit cards for person 2, wallet 1
            List<CreditCard> PersonWalletTwoCCs = new List<CreditCard>();
            PersonWalletTwoCCs.Add(new Visa(decBalance, intTime));
            PersonWalletTwoCCs.Add(new MasterCard(decBalance, intTime));
            // create two wallets (one for each person)
            List<Wallet> PersonOneWallet = new List<Wallet>();
            PersonOneWallet.Add(new Wallet(PersonWalletOneCCs));
            List<Wallet> PersonTwoWallet = new List<Wallet>();
            PersonTwoWallet.Add(new Wallet(PersonWalletTwoCCs));
            // create two customers
            List<Customer> PersonList = new List<Customer>();
            PersonList.Add(new Customer("Lane Turner", PersonOneWallet));
            PersonList.Add(new Customer("Andrew Turner", PersonTwoWallet));

            // calculate total interest combined
            CreditCardCalcHelper ccHelper = new CreditCardCalcHelper();
            Assert.AreEqual(30, ccHelper.CalculateTotalInterest(PersonList));
        }

    }
}
