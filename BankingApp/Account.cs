using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankingApp
{
    public abstract class Account : IAccount
    {
        protected double startingBalance;
        protected double currentBalance;
        protected double totalDeposits;
        protected double amountofDeposits;
        protected double totalWithdraws;
        protected double annualInterestRate;
        protected double monthServiceCharge;
        protected AccountStatus status;
        protected enum AccountStatus
        {
            Active,
            Inactive
        };

        public Account(double balance, double interest)
        {
            currentBalance = balance;
            annualInterestRate = interest;
        }

        public virtual void MakeDeposit(double deposit)
        {
           currentBalance += deposit;
            totalDeposits++;
        }
        
        public virtual void MakeWithdraw (double withdraw)
        {
            currentBalance -= withdraw;
            totalWithdraws++;
          
        }
        public double CalculateInterest(double yearlyInterest)
        {
            annualInterestRate = yearlyInterest;
            double monthlyInterestRate = (yearlyInterest / 12);
            double monthlyInterest = (currentBalance * monthlyInterestRate);
            double balanceInt = currentBalance + monthlyInterest;
            return balanceInt;
        }

        public double Percentage(double balance)
        {
            currentBalance = balance;
            double percentage = ((currentBalance - startingBalance)/startingBalance)*100;
            return percentage;
        }

        public virtual string CloseAndReport(double yearlyInterest, double service)
        {
            CalculateInterest( yearlyInterest);

            monthServiceCharge = service;

            double newBalance =  CalculateInterest(yearlyInterest) - service;

            
            string str = "Starting Balance: $5" + "\nBalance with Interest before Service Charges: $" + CalculateInterest(yearlyInterest) + 
                "\nService Charges: $" + service + "\nCurrent Balance: $" + newBalance + 
                "\nTotal Amount of Deposits: $" + totalDeposits + "\nTotal Amount of Withdraws: $" + totalWithdraws 
                + "\nChange Percentage: " + Percentage(currentBalance) +"%";
          
            return str; 

        }

        public void Clear()
        {
            double startingBalance = 0;
            double currentBalance = 0;
             double totalDeposits = 0;
            double amountofDeposits = 0;
             double totalWithdraws = 0;
             double annualInterestRate = 0;
             double monthServiceCharge = 0;
        }
        
    }
}
