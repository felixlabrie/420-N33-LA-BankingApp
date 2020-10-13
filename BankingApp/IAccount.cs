using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    interface IAccount
    {
        void MakeWithdraw(double withdraw);
        void MakeDeposit(double deposit);
        double CalculateInterest(double yearlyInterest, double monthlyInterestRate, double monthlyInterest, double balance);
        string CloseAndReport(double yearlyInterest, double monthlyInterestRate, double monthlyInterest, double balance, double newBalance, double service, double change, string str);
    }
}
