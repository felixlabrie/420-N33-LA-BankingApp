using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    interface IAccount
    {
        void MakeWithdrawl(double withdrawl);
        void MakeDeposit(double deposit);
        double CalculateInterest(double yearlyInterest, double monthlyInterestRate, double monthlyInterest, double balance);
        string CloseAndReport(double oldBalance, double newBalance, double service, double change, string str);
    }
}
