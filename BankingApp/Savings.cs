﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class Savings : Account ,IAccount 
    {
        public Savings(double balance, double interest) : base(balance, interest)
        {
            base.currentBalance = balance;
            base.annualInterestRate = interest;
            
        }
        public override void MakeDeposit(double deposit)
        {
            
            base.MakeDeposit(deposit);
            if (base.currentBalance >= 25)
                            base.status = AccountStatus.Active;
                        else
                            base.status = AccountStatus.Inactive;
            if (base.status == AccountStatus.Active)
            {
                
                Console.WriteLine("You have successfully deposited $" + deposit + " into your account, your current balance is: $" + currentBalance);
                
            }
            else 
            {
                double remaining = 25 - currentBalance;
                
                Console.WriteLine("You have successfully deposited $" + deposit + " but your account is still inactive.");
                Console.WriteLine("To activate your account, please add $" + remaining); 
                
            }
           
        }
        public override void MakeWithdraw(double withdraw)
        {
            if (base.currentBalance >= 25)
                base.status = AccountStatus.Active;
            else
                base.status = AccountStatus.Inactive;

            if (base.status == AccountStatus.Active)
            {
                if (base.status == AccountStatus.Inactive)
                {

                    Console.WriteLine("Due to your withdraw, your account is now inactive.");
                    double remaining = 25 - currentBalance;
                    Console.WriteLine("In order to active your account, please add $" + remaining);


                }
                if (currentBalance >= withdraw)
                {
                    base.MakeWithdraw(withdraw);
                    Console.WriteLine("You have successfully withdrew $" + withdraw + ", your remaining balance is: $" + currentBalance);
                }
                else
                {
                    Console.WriteLine("You do not have sufficient funds to withdraw this amount, your current balance is: $" + currentBalance);
                }
                
                    
                
            }
            else
            {
                
                Console.WriteLine("Your account balance must be at least $25 in order to withdraw money");
                Console.WriteLine("Your current balance is : $" + currentBalance);
                
            }

        }

        public override string CloseAndReport(double yearlyInterest, double service)
        {
            if (base.totalWithdraws <= 4)
            {
                return base.CloseAndReport(yearlyInterest, service);
            }
            else
                service += totalWithdraws - 4;
                return base.CloseAndReport(yearlyInterest, service);

        }



    }
}
