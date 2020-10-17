using System;

namespace BankingApp.ExtensionMethods
{
    public static class ExtentionMethods
    {
        public static string ToNAMoneyFormat(this double number, Boolean tf)
        {
            string result = value.ToString("C", CultureInfo.CurrentCulture);
           
            return result;
        }
    }
}
