﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Chequing : Account, IAccount 
    {
        public Chequing(double balance, double interest) : base(balance, interest)
        {
            base.currentBalance = balance;
            base.annualInterestRate = interest;
            
        }

        public override void MakeWithdraw(double withdraw)
        {
           double amount =  currentBalance - withdraw;
            if (amount < 0)
            {
                currentBalance = currentBalance - 15;
                Console.WriteLine("You do not have sufficient funds to continue this withdraw, a service charge of $15 has been added");
            }
            else
                base.MakeWithdraw(withdraw);

        }

        public override void MakeDeposit(double deposit)
        {
            base.MakeDeposit(deposit);
            Console.WriteLine("You have successfully deposited $" + deposit + "into your account, your current balance is $" + currentBalance);
        }
       

        public override string CloseAndReport(double oldBalance, double newBalance, double service, double change, string str)
        {
            service += 5 + (0.1 * totalWithdraws);
            return base.CloseAndReport(oldBalance, newBalance, service, change, str);

        }
    }
}
