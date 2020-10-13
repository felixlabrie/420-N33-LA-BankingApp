using System;
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
            if (base.currentBalance > 25)
                base.status = AccountStatus.Active;
            else
                base.status = AccountStatus.Inactive;
        }
        public override void MakeDeposit(double deposit)
        {
            base.MakeDeposit(deposit);
            if (base.currentBalance > 25)
            {
                base.status = AccountStatus.Active;
                Console.WriteLine("You have successfully deposited $" + deposit + "into your account, your current balance is: $" + currentBalance);
            }
            else
            {
                double remaining = 25 - currentBalance;
                Console.WriteLine("You have successfully deposited $" + deposit + "but your account is still inactive.");
                Console.WriteLine("To activate your account, please add $" + remaining);
             }         
                
        }
        public override void MakeWithdraw(double withdraw)
        {
            if (base.status == AccountStatus.Active)
            {
                
                if (base.currentBalance <= 25)
                {
                    base.status = AccountStatus.Inactive;
                    Console.WriteLine("Your account balance must be at least $25 for your account to be active in order to withdraw money");
                    Console.WriteLine("Your current balance is : " + currentBalance);
                }
                else
                    base.MakeWithdraw(withdraw);
                    Console.WriteLine("You have successfully withdrew $" + withdraw + ", your remaining balance is: $" + currentBalance);
            }
            
        }

        public override string CloseAndReport(double oldBalance, double newBalance, double service, double change, string str)
        {
            if (base.totalWithdraws <= 4)
            {
                return base.CloseAndReport(oldBalance, newBalance, service, change, str);
            }
            else
                service += totalWithdraws - 4;
                return base.CloseAndReport(oldBalance, newBalance, service, change, str);

        }



    }
}
