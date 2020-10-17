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
        double CalculateInterest(double yearlyInterest);
        string CloseAndReport(double yearlyInterest, double service);
    }
}
