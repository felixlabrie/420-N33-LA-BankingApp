using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class GlobalSavingsAcount : Savings, IExchangeable
    {
        public GlobalSavingsAcount(double balance, double interest) : base(balance, interest)
        {
            base.currentBalance = balance;
            base.annualInterestRate = interest;
        }

        public double USValue(double rate)
        {
            rate = 0.75;
            double USD = currentBalance * rate;
            return USD;
        }

    }
}
