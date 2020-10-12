using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    abstract class Account 
    {
        private double StartingBalance;
        private double CurrentBalance;
        private double TotalDeposits;
        private double AmountofDeposits;
        private double TotalWithdrawls;
        private double InterestRate;
        private double MonthServiceCharge;
        private double AccountStatus;

        public Account(double CurrentBalance, double InterestRate)
        {
            CurrentBalance = this.CurrentBalance;
            InterestRate = this.InterestRate;
        }

        static void MakeDeposit(double Deposit)
        {
            
        }
    }
}
