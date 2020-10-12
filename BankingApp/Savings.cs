using System;
using System.Collections.Generic;
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
                base.status = AccountStatus.Active;
        }
        public override void MakeWithdrawl(double withdrawl)
        {
            if (base.status == AccountStatus.Active)
            {
                base.MakeWithdrawl(withdrawl);
                if (base.currentBalance<= 25)
                    base.status = AccountStatus.Inactive;
            }
            
        }

        public override string CloseAndReport(double oldBalance, double newBalance, double service, double change, string str)
        {
            if (base.totalWithdrawls <= 4)
            {
                return base.CloseAndReport(oldBalance, newBalance, service, change, str);
            }
            else
                monthServiceCharge += totalWithdrawls - 4;
                return base.CloseAndReport(oldBalance, newBalance, service, change, str);

        }



    }
}
