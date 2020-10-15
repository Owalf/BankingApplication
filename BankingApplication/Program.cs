using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount(5.00, .15);
            ChequingAccount chequing = new ChequingAccount(5.00, .05);
            GlobalSavingsAccount globalsavings = new GlobalSavingsAccount(5.00, .15);

            Console.WriteLine("Welcome to OmegaBank, please select an account type.");
            Console.WriteLine("A: Savings");
            Console.WriteLine("B: Checking");
            Console.WriteLine("C: GlobalSavings");
            Console.WriteLine("Q: Exit");
            string AccountType = Console.ReadLine();

            switch(AccountType.ToUpper())
            {
                case "A":
                    Console.WriteLine("Savings Menu");
                    Console.WriteLine("A: Deposit");
                    Console.WriteLine("B: Withdraw");
                    Console.WriteLine("C: Close + Report");
                    Console.WriteLine("R: Return to Bank Menu");

                    string Option = Console.ReadLine();

                    switch(Option.ToUpper())
                    {
                        case "A":
                            Console.WriteLine("How much do you want to deposit?");
                            double amount = Console.ReadLine();
                            SavingsAccount.MakeDeposit(amount);
                    }
                    break;
                case "B":
                    Console.WriteLine("Savings Menu");
                    Console.WriteLine("A: Deposit");
                    Console.WriteLine("B: Withdraw");
                    Console.WriteLine("C: Close + Report");
                    Console.WriteLine("R: Return to Bank Menu");
                    break;
                case "C":
                    Console.WriteLine("Savings Menu");
                    Console.WriteLine("A: Deposit");
                    Console.WriteLine("B: Withdraw");
                    Console.WriteLine("C: Close + Report");
                    Console.WriteLine("D: Report Balance in USD");
                    Console.WriteLine("R: Return to Bank Menu");
                    break;
                case "Q":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
