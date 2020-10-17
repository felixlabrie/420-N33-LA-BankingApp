using System;
using System.Globalization;

namespace BankingApp.ExtensionMethods
{
    public static class ExtentionMethods
    {
        public static string ToNAMoneyFormat(this double number)
        {
            string result = number.ToString("C", CultureInfo.CurrentCulture);
           
            return result;
        }
    }
}
