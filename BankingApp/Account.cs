using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BankingApp.ExtensionMethods;

namespace BankingApp 
{
    public abstract class Account : IAccount 
    {
        protected double STARTINGBALANCE = 5;
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
            double monthlyInterestRate = (yearlyInterest / 12 / 100);
            double monthlyInterest = (currentBalance * monthlyInterestRate);
            double balanceInt = currentBalance + monthlyInterest;
            return balanceInt;
        }

        public double Percentage(double balance)
        {
            currentBalance = balance;
            double difference = (currentBalance - STARTINGBALANCE);
            double percentage = (difference / currentBalance)*100;
            return percentage;
        }

        public virtual string CloseAndReport(double yearlyInterest, double service)
        {
            CalculateInterest( yearlyInterest);

            monthServiceCharge = service;

            double newBalance =  CalculateInterest(yearlyInterest) - service;


            string str = "Starting Balance: " + STARTINGBALANCE.ToNAMoneyFormat() + "\nBalance with Interest before Service Charges: " + CalculateInterest(yearlyInterest) + 
                "\nService Charges: " + service.ToNAMoneyFormat() + "\nCurrent Balance: " + newBalance.ToNAMoneyFormat() + 
                "\nTotal Amount of Deposits: " + totalDeposits + "\nTotal Amount of Withdraws: " + totalWithdraws
                + "\nChange Percentage: " + Percentage(currentBalance) + "%";
          
            return str; 

        }

       public void Clear()
        {
            STARTINGBALANCE = 0;
            currentBalance = 0;
            totalDeposits = 0;
            amountofDeposits = 0;
            totalWithdraws = 0;
            annualInterestRate = 0;
            monthServiceCharge = 0;
        }
        
    }
}
