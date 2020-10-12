using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public abstract class Account : IAccount
    {
        private double startingBalance;
        private double currentBalance;
        private double totalDeposits;
        private double amountofDeposits;
        private double totalWithdrawls;
        private double annualInterestRate;
        private double monthServiceCharge;
        private double accountStatus;

        public Account(double balance, double interest)
        {
            currentBalance = balance;
            annualInterestRate = interest;
        }

        public void MakeDeposit(double deposit)
        {
           currentBalance += deposit;
        }
        
        public void MakeWithdrawl (double withdrawl)
        {
           currentBalance -= withdrawl;
        }
        public double CalculateInterest(double yearlyInterest, double monthlyInterestRate, double monthlyInterest, double balance)
        {
            annualInterestRate = yearlyInterest;
            currentBalance = balance;
            monthlyInterestRate = (yearlyInterest / 12);
            monthlyInterest = (balance * monthlyInterestRate);
            balance = balance + monthlyInterest;
            return balance;
        }

        public string CloseAndReport(double oldBalance, double newBalance, double service, double change, string str)
        {
            currentBalance = oldBalance;
            monthServiceCharge = service; 
            newBalance = oldBalance + service; 

            str = "Previous Balance: " + oldBalance + "\nNew Balance: " + newBalance;

            return str; 

        }

    }
}
