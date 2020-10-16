using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc;
           

            bool continuepar = false;

            while (continuepar == false) 
            {
                string type = ShowBankMenu();
               
                if (type == "A" || type == "B" || type == "C" || type == "D")
                {

                    continuepar = true;
                    
                    switch (type)
                    {
                        //SAVINGS
                        case "A":
                            acc = new Savings(5, 10);
                            bool savings = true;
                            while (savings == true)
                            {
                                string action = ShowSavingsMenu();
                                switch (action)
                                {
                                    //SAVINGS deposit
                                    case "A":
                                        
                                        bool tryagain = true;
                                        while (tryagain == true)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Enter the amount you would like to deposit");
                                            Console.WriteLine();
                                            string deposit = Console.ReadLine();
                                            double amount;
                                            bool bParse = Double.TryParse(deposit, out amount);
                                            if (bParse)
                                            {

                                                acc.MakeDeposit(amount);

                                                //yes or no to to question
                                                bool question = true;

                                                while (question == true)
                                                {
                                                    Console.WriteLine("Would You Like to Go Back to Your Account for Another Action? Y = yes / N = no");
                                                    string answer = Console.ReadLine();
                                                    answer = answer.ToUpper();


                                                    if (answer == "Y")
                                                    {
                                                        question = false;
                                                        tryagain = false;
                                                        savings = true;
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
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid input");
                                                Console.WriteLine();
                                                tryagain = true;
                                            }
                                        }

                                        break;

                                    //SAVINGS withdraw
                                    case "B":

                                        bool tryagain2 = true;
                                        while(tryagain2 == true)
                                        {

                                            Console.WriteLine("Please enter the amount you would like to withdraw");

                                            string withdraw = Console.ReadLine();
                                            double amount;
                                            bool bParse = Double.TryParse(withdraw, out amount);
                                            if (bParse)
                                            {
                                                tryagain2 = true;
                                                acc.MakeWithdraw(amount);
                                                bool question = true;
                                                while (question == true)
                                                {
                                                    Console.WriteLine("Would You Like to Go Back to Your Account for Another Action? Y = yes / N = no");
                                                    string answer = Console.ReadLine();
                                                    answer = answer.ToUpper();


                                                    if (answer == "Y")
                                                    {
                                                        question = false;
                                                        tryagain2 = false;
                                                        savings = true;
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
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Please enter a valid input");

                                                tryagain2 = false;
                                            }
                                        } 

                                        break;

                                    //SAVINGS report
                                    case "C":

                                        break;
                                    case "R":
                                        savings = false;
                                        continuepar = false;
                                        break;
                                }




                            }
                        break;
                         
                        //CHEQUING
                        case "B":
                            acc = new Chequing(5, 12);
                            bool chequing = true;
                            while (chequing == true)
                            {
                                string action2 = ShowChequingMenu();

                                switch (action2)
                                {
                                    //CHEQUING deposit
                                    case "A":

                                        bool tryagain = true;
                                        while (tryagain == true)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Enter the amount you would like to deposit");
                                            Console.WriteLine();
                                            string deposit = Console.ReadLine();
                                            double amount;
                                            bool bParse = Double.TryParse(deposit, out amount);
                                            if (bParse)
                                            {

                                                acc.MakeDeposit(amount);

                                                //yes or no to to question
                                                bool question = true;

                                                while (question == true)
                                                {
                                                    Console.WriteLine("Would You Like to Go Back to Your Account for Another Action? Y = yes / N = no");
                                                    string answer = Console.ReadLine();
                                                    answer = answer.ToUpper();


                                                    if (answer == "Y")
                                                    {
                                                        question = false;
                                                        tryagain = false;
                                                        chequing = true;
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
                                            else
                                            {
                                                Console.WriteLine("Please enter a valid input");
                                                Console.WriteLine();
                                                tryagain = true;
                                            }
                                        }


                                        break;

                                    //CHEQUING withdraw
                                    case "B":

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
                                                acc.MakeWithdraw(amount);
                                                bool question = true;
                                                while (question == true)
                                                {
                                                    Console.WriteLine("Would You Like to Go Back to Your Account for Another Action? Y = yes / N = no");
                                                    string answer = Console.ReadLine();
                                                    answer = answer.ToUpper();


                                                    if (answer == "Y")
                                                    {
                                                        question = false;
                                                        tryagain2 = false;
                                                        chequing = true;
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
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Please enter a valid input");

                                                tryagain2 = false;
                                            }
                                        }


                                        break;

                                    //CHEQUING report
                                    case "C":

                                        break;
                                    case "R":
                                        continuepar = false;
                                        break;
                                }
                            }
                            break;
                        //GLOBAL
                        case "C":
                            acc = new GlobalSavingsAcount(5, 15);
                            break;
                        //QUIT
                        case "D":
                            Environment.Exit(0);
                            break;

                    }
                } else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid answer. Please enter A, B, C or D.");
                    Console.WriteLine();

                }


            } 





        }

        static string ShowBankMenu()
        {
            string type;

            Console.WriteLine("Bank Menu");
            Console.WriteLine();
            Console.WriteLine("Please select an account type:");
            Console.WriteLine("A. Savings");
            Console.WriteLine("B. Chequing");
            Console.WriteLine("C. Global Savings");
            Console.WriteLine("D. Exit");
            Console.WriteLine();

            type = Console.ReadLine();
            return type.ToUpper();
        }

        static string ShowSavingsMenu()
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

            action = Console.ReadLine();
            return action.ToUpper();
        }

        static string ShowChequingMenu()
        {
            string action2;

            Console.WriteLine();
            Console.WriteLine("Chequing Menu");
            Console.WriteLine();
            Console.WriteLine("What would you like to do today?:");
            Console.WriteLine("A. Deposit");
            Console.WriteLine("B. Withdraw");
            Console.WriteLine("C. Close + Report");
            Console.WriteLine("R. Return to Main Menu");
            Console.WriteLine();

            action2 = Console.ReadLine();
            return action2.ToUpper();
        }

    }
}
