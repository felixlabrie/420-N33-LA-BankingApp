using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.ExtensionMethods;


namespace BankingApp
{
    class Methods
    {
        Savings s1 = new Savings(5, .10);
        Chequing c1 = new Chequing(5, .12);
        GlobalSavingsAcount g1 = new GlobalSavingsAcount(5, .15);
        public void ShowBankMenu()
        {

            string type;
            
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
                if (type != "A" && type != "B" && type != "C" && type != "Q")

                {
                    Console.WriteLine();
                     invalidInput();
                     Console.WriteLine();
                    ShowBankMenu();
                }
            
        }

        public void ShowSavingsMenu()
        {

            string action;
          
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
                if (action != "A" && action != "B" && action != "C" && action != "R")

                {
                    Console.WriteLine();
                    invalidInput();
                    Console.WriteLine();
                    ShowSavingsMenu();
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
                invalidInput();
                Console.WriteLine();

            }

        }

        public void SavingsCaseB()
        {
           Console.WriteLine("Please enter the amount you would like to withdraw");

                string withdraw = Console.ReadLine();
                double amount;
                bool bParse = Double.TryParse(withdraw, out amount);
                if (bParse)
                {
                    s1.MakeWithdraw(amount);
                    SQuestion();
                }
                else
                {
                    Console.WriteLine();
                    invalidInput();
                    Console.WriteLine();
                    SavingsCaseB();
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
                if (action != "A" && action != "B" && action != "C" && action != "R")

                {
                    Console.WriteLine();
                    invalidInput();
                    Console.WriteLine();
                    ShowSavingsMenu();
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
                invalidInput();
                Console.WriteLine();

            }

        }

        public void ChequingCaseB()
        {
            
                Console.WriteLine("Please enter the amount you would like to withdraw");

                string withdraw = Console.ReadLine();
                double amount;
                bool bParse = Double.TryParse(withdraw, out amount);
                if (bParse)
                {
                    c1.MakeWithdraw(amount);
                    CQuestion();
                }
                else
                {
                    Console.WriteLine();
                    invalidInput();
                    Console.WriteLine();
                    ChequingCaseB();

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
                if (action != "A" && action != "B" && action != "C" && action != "D" && action != "R")

                {
                    Console.WriteLine();
                    invalidInput();
                    Console.WriteLine();
                    ShowGlobalMenu();
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
                Console.WriteLine();
                invalidInput();
                GlobalCaseA();
            }
        }
        public void GlobalCaseB()
        {
           
                Console.WriteLine("Please enter the amount you would like to withdraw");

                string withdraw = Console.ReadLine();
                double amount;
                bool bParse = Double.TryParse(withdraw, out amount);
                if (bParse)
                {
                    g1.MakeWithdraw(amount);
                    GQuestion();
                }
                else
                {
                    Console.WriteLine();
                    invalidInput();
                    Console.WriteLine();
                    ShowGlobalMenu();
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
            GQuestion();
        }
        public void SQuestion()
        {
                Console.WriteLine("Would You Like to Go Back to Your Account for Another Action? Y = yes / N = no");
                string answer = Console.ReadLine();
                answer = answer.ToUpper();


                if (answer == "Y")
                {
                    ShowSavingsMenu();
                }
                else if (answer == "N")
                {
                    Environment.Exit(0);
                }
                else
                {
                    invalidInput();
                    Console.WriteLine();
                    SQuestion();
                }
            
        }
        public void CQuestion()
        {
                Console.WriteLine("Would You Like to Go Back to Your Account for Another Action? Y = yes / N = no");
                string answer = Console.ReadLine();
                answer = answer.ToUpper();


                if (answer == "Y")
                {
                    ShowChequingMenu();
                }
                else if (answer == "N")
                {
                    Environment.Exit(0);
                }
                else
                {
                    invalidInput();
                    Console.WriteLine();
                    CQuestion();
                }
            
        }
        public void GQuestion()
        {
            
                Console.WriteLine("Would You Like to Go Back to Your Account for Another Action? Y = yes / N = no");
                string answer = Console.ReadLine();
                answer = answer.ToUpper();


                if (answer == "Y")
                {
                    ShowGlobalMenu();
                }
                else if (answer == "N")
                {
                    Environment.Exit(0);
                }
                else
                {
                    invalidInput();
                    Console.WriteLine();
                    GQuestion();
                }
            
        }
        public void ClosedAccount()
        {
            Console.WriteLine("You have successfully closed your account!");

            Console.WriteLine("Return to main menu? Y = yes / N = no");
                string answer = Console.ReadLine();
                answer = answer.ToUpper();


                if (answer == "Y")
                {
                    ShowBankMenu();
                }
                else if (answer == "N")
                {
                    Environment.Exit(0);
                }
                else
                {
                    invalidInput();
                    Console.WriteLine();
                    ClosedAccount();
                }
            
        }
        public void invalidInput()
        {
            Console.WriteLine("Invalid input, try again.");
        }

       

    }
    
}



