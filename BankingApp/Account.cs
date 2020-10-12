﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public abstract class Account : IAccount
    {
        protected double startingBalance;
        protected double currentBalance;
        protected double totalDeposits;
        protected double amountofDeposits;
        protected double totalWithdrawls;
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
        
        public virtual void MakeWithdrawl (double withdrawl)
        {
           currentBalance -= withdrawl;
            totalWithdrawls++;
          
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

        public virtual string CloseAndReport(double oldBalance, double newBalance, double service, double change, string str)
        {
            currentBalance = oldBalance;
            monthServiceCharge = service; 
            newBalance = oldBalance - service;
            change = ((oldBalance - newBalance) / oldBalance) * 100;
            str = "Previous Balance: " + oldBalance + "\nNew Balance: " + newBalance + "\nChange Percentage: " + change;

            return str; 

        }


        
    }
}
