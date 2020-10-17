using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.ExtensionMethods;
using BankingApp.ExtensionMethods;

namespace BankingApp
{
    class Methods
    {
        Savings s1 = new Savings(5, 10);
        Chequing c1 = new Chequing(5, 12);
        GlobalSavingsAcount g1 = new GlobalSavingsAcount(5, 15);
        public void ShowBankMenu()
        {

            string type;
            bool keepgoing = false;
            while (keepgoing == false)
            {
                Console.WriteLine("Bank Menu");
                Console.WriteLine();
                Console.WriteLine("Please select an account type:");
                Console.WriteLine("A. Savings");
                Console.WriteLine("B. Chequing");
                Console.WriteLine("C. Global Savings");
                Console.WriteLine("Q. Exit");
                Console.WriteLine();

                type = Console.ReadLine().ToUpper();

                switch (type)
                {
                    case "A":
                        ShowSavingsMenu();
                        break;
                    case "B":
                        ShowChequingMenu();
                        break;
                    case "C":
                        ShowGlobalMenu();
                        break;
                    case "Q":
                        Environment.Exit(0);
                        break;
                }
                if (type != "A" | type != "B" | type != "C" | type != "Q")

                {
                    keepgoing = true;
                    Console.WriteLine("Invalid answer. Please enter A, B, C or D.");
                    Console.WriteLine();
                }
            }
        }

        public void ShowSavingsMenu()
        {

            string action;
            bool savings = true;
            while (savings == true)
            {
                Console.WriteLine();
                Console.WriteLine("Savings Menu");
                Console.WriteLine();
                Console.WriteLine("What would you like to do today?:");
                Console.WriteLine("A. Deposit");
                Console.WriteLine("B. Withdraw");
                Console.WriteLine("C. Close + Report");
                Console.WriteLine("R. Return to Main Menu");
                Console.WriteLine();
                action = Console.ReadLine().ToUpper();

                switch (action)
                {
                    case "A":
                        SavingsCaseA();
                        break;
                    case "B":
                        SavingsCaseB();
                        break;
                    case "C":
                        SavingsCaseC();
                        break;
                    case "R":
                        ShowBankMenu();
                        break;
                }
            }
        }

        public void SavingsCaseA()
        {
            
            Console.WriteLine("Enter the amount you would like to deposit");
            Console.WriteLine();
            string deposit = Console.ReadLine();
            double amount;
            bool bParse = Double.TryParse(deposit, out amount);
            if (bParse)
            {

                s1.MakeDeposit(amount);
                SQuestion();
            }
            else
            {
                Console.WriteLine("Please enter a valid input");
                Console.WriteLine();

            }

        }

        public void SavingsCaseB()
        {
            bool tryagain2 = true;
            while (tryagain2 == true)
            {
                Console.WriteLine("Please enter the amount you would like to withdraw");

                string withdraw = Console.ReadLine();
                double amount;
                bool bParse = Double.TryParse(withdraw, out amount);
                if (bParse)
                {
                    tryagain2 = true;
                    s1.MakeWithdraw(amount);
                    SQuestion();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid input");

                    tryagain2 = false;
                }
            }
        }

        public void SavingsCaseC()
        {
            Console.WriteLine(s1.CloseAndReport(10, 10));
            Console.WriteLine();
            s1.Clear();
            ClosedAccount();
            Console.WriteLine();
            ShowBankMenu();
        }
        public void ShowChequingMenu()
        {
            string action;
            bool chequing = true;
            while (chequing == true)
            {
                Console.WriteLine();
                Console.WriteLine("Chequing Menu");
                Console.WriteLine();
                Console.WriteLine("What would you like to do today?:");
                Console.WriteLine("A. Deposit");
                Console.WriteLine("B. Withdraw");
                Console.WriteLine("C. Close + Report");
                Console.WriteLine("R. Return to Main Menu");
                Console.WriteLine();
                action = Console.ReadLine().ToUpper();

                switch (action)
                {
                    case "A":
                        ChequingCaseA();
                        break;
                    case "B":
                        ChequingCaseB();
                        break;
                    case "C":
                        ChequingCaseC();
                        break;
                    case "R":
                        ShowBankMenu();
                        break;

                }
            }

        }

        public void ChequingCaseA()
        {
            Console.WriteLine("Enter the amount you would like to deposit");
            Console.WriteLine();
            string deposit = Console.ReadLine();
            double amount;
            bool bParse = Double.TryParse(deposit, out amount);
            if (bParse)
            {

                c1.MakeDeposit(amount);
                CQuestion();
            }
            else
            {
                Console.WriteLine("Please enter a valid input");
                Console.WriteLine();

            }

        }

        public void ChequingCaseB()
        {
            bool tryagain2 = true;
            while (tryagain2 == true)
            {
                Console.WriteLine("Please enter the amount you would like to withdraw");

                string withdraw = Console.ReadLine();
                double amount;
                bool bParse = Double.TryParse(withdraw, out amount);
                if (bParse)
                {
                    tryagain2 = true;
                    c1.MakeWithdraw(amount);
                    CQuestion();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid input");

                    tryagain2 = false;
                }
            }
        }


        public void ChequingCaseC()
        {
            Console.WriteLine(c1.CloseAndReport(10, 10));
            Console.WriteLine();
            c1.Clear();
            ClosedAccount();
            Console.WriteLine();
            ShowBankMenu();
        }

        public void ShowGlobalMenu()
        {
            string action;
            bool global = true;
            while (global == true)
            {
                Console.WriteLine();
                Console.WriteLine("Global Savings Menu");
                Console.WriteLine();
                Console.WriteLine("What would you like to do today?:");
                Console.WriteLine("A. Deposit");
                Console.WriteLine("B. Withdraw");
                Console.WriteLine("C. Close + Report");
                Console.WriteLine("D. Report Balance in USD");
                Console.WriteLine("R. Return to Main Menu");
                Console.WriteLine();
                action = Console.ReadLine().ToUpper();
                switch (action)
                {
                    case "A":
                        GlobalCaseA();
                        break;
                    case "B":
                        GlobalCaseB();
                        break;
                    case "C":
                        GlobalCaseC();
                        break;
                    case "D":
                        GlobalCaseD();
                        break;
                    case "R":
                        ShowBankMenu();
                        break;
                }
            }

        }
        public void GlobalCaseA()
        {
            Console.WriteLine("Enter the amount you would like to deposit");
            Console.WriteLine();
            string deposit = Console.ReadLine();
            double amount;
            bool bParse = Double.TryParse(deposit, out amount);
            if (bParse)
            {

                g1.MakeDeposit(amount);
               GQuestion();
            }
            else
            {
                Console.WriteLine("Please enter a valid input");
                Console.WriteLine();

            }
        }
        public void GlobalCaseB()
        {
            bool tryagain2 = true;
            while (tryagain2 == true)
            {
                Console.WriteLine("Please enter the amount you would like to withdraw");

                string withdraw = Console.ReadLine();
                double amount;
                bool bParse = Double.TryParse(withdraw, out amount);
                if (bParse)
                {
                    tryagain2 = true;
                    g1.MakeWithdraw(amount);
                    GQuestion();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid input");

                    tryagain2 = false;
                }
            }

        }
        public void GlobalCaseC()
        {
            Console.WriteLine(g1.CloseAndReport(10, 10));
            Console.WriteLine();
            g1.Clear();
            ClosedAccount();
            Console.WriteLine();
            ShowBankMenu();
        }
        public void GlobalCaseD()
        {
            Console.WriteLine(g1.USValue(0.75).ToNAMoneyFormat());
        }
        public void SQuestion()
        {
            bool question = true;

            while (question == true)
            {
                Console.WriteLine("Would You Like to Go Back to Your Account for Another Action? Y = yes / N = no");
                string answer = Console.ReadLine();
                answer = answer.ToUpper();


                if (answer == "Y")
                {
                    question = false;
                    ShowSavingsMenu();
                }
                else if (answer == "N")
                {
                    question = false;
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter Y for yes or N for no");
                    question = true;
                }
            }
        }
        public void CQuestion()
        {
            bool question = true;

            while (question == true)
            {
                Console.WriteLine("Would You Like to Go Back to Your Account for Another Action? Y = yes / N = no");
                string answer = Console.ReadLine();
                answer = answer.ToUpper();


                if (answer == "Y")
                {
                    question = false;
                    ShowChequingMenu();
                }
                else if (answer == "N")
                {
                    question = false;
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter Y for yes or N for no");
                    question = true;
                }
            }
        }
        public void GQuestion()
        {
            bool question = true;

            while (question == true)
            {
                Console.WriteLine("Would You Like to Go Back to Your Account for Another Action? Y = yes / N = no");
                string answer = Console.ReadLine();
                answer = answer.ToUpper();


                if (answer == "Y")
                {
                    question = false;
                    ShowGlobalMenu();
                }
                else if (answer == "N")
                {
                    question = false;
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter Y for yes or N for no");
                    question = true;
                }
            }
        }
        public void ClosedAccount()
        {
            Console.WriteLine("You have successfully closed your account!");

            bool question = true;

            while (question == true)
            {
                Console.WriteLine("Return to main menu? Y = yes / N = no");
                string answer = Console.ReadLine();
                answer = answer.ToUpper();


                if (answer == "Y")
                {
                    question = false;
                    ShowBankMenu();
                }
                else if (answer == "N")
                {
                    question = false;
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter Y for yes or N for no");
                    question = true;
                }
            }
        }

       

    }
    
}



