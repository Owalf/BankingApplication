﻿using System;
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
            GlobalSavingsAccount globalSavings = new GlobalSavingsAccount(5.00, .15);

            while (true)
            {
                Console.WriteLine("Welcome to OmegaBank, please select an account type.");
                Console.WriteLine("A: Savings");
                Console.WriteLine("B: Checking");
                Console.WriteLine("C: GlobalSavings");
                Console.WriteLine("Q: Exit");
                string AccountType = Console.ReadLine();

                switch (AccountType.ToUpper())
                {
                    case "A":
                        Console.WriteLine("\nSavings Menu");
                        Console.WriteLine("A: Deposit");
                        Console.WriteLine("B: Withdraw");
                        Console.WriteLine("C: Close + Report");
                        Console.WriteLine("R: Return to Bank Menu");

                        string savingsOption = Console.ReadLine();

                        switch (savingsOption.ToUpper())
                        {
                            case "A":
                                Console.WriteLine("How much do you want to deposit?");
                                string depositAmount = Console.ReadLine();
                                double.TryParse(depositAmount, out double deposit);
                                savings.MakeDeposit(deposit);
                                break;
                            case "B":
                                Console.WriteLine("How much do you want to withdraw?");
                                string withdrawAmount = Console.ReadLine();
                                double.TryParse(withdrawAmount, out double withdraw);
                                savings.MakeWithdrawal(withdraw);
                                break;
                            case "C":
                                savings.CloseAndReport();
                                break;
                            case "R":
                                AccountType = Console.ReadLine();
                                break;
                            default:
                                break;
                        }
                        break;
                    case "B":
                        Console.WriteLine("\nChequings Menu");
                        Console.WriteLine("A: Deposit");
                        Console.WriteLine("B: Withdraw");
                        Console.WriteLine("C: Close + Report");
                        Console.WriteLine("R: Return to Bank Menu");

                        string chequingOption = Console.ReadLine();

                        switch (chequingOption.ToUpper())
                        {
                            case "A":
                                Console.WriteLine("How much do you want to deposit?");
                                string depositAmount = Console.ReadLine();
                                double.TryParse(depositAmount, out double deposit);
                                chequing.MakeDeposit(deposit);
                                break;
                            case "B":
                                Console.WriteLine("How much do you want to withdraw?");
                                string withdrawAmount = Console.ReadLine();
                                double.TryParse(withdrawAmount, out double withdraw);
                                chequing.MakeWithdrawal(withdraw);
                                break;
                            case "C":
                                chequing.CloseAndReport();
                                break;
                            default:
                                break;
                        }
                        break;
                    case "C":
                        Console.WriteLine("\nGlobalSavings Menu");
                        Console.WriteLine("A: Deposit");
                        Console.WriteLine("B: Withdraw");
                        Console.WriteLine("C: Close + Report");
                        Console.WriteLine("D: Report Balance in USD");
                        Console.WriteLine("R: Return to Bank Menu");

                        string globalSavingsOption = Console.ReadLine();

                        switch (globalSavingsOption.ToUpper())
                        {
                            case "A":
                                Console.WriteLine("How much do you want to deposit?");
                                string depositAmount = Console.ReadLine();
                                double.TryParse(depositAmount, out double deposit);
                                globalSavings.MakeDeposit(deposit);
                                break;
                            case "B":
                                Console.WriteLine("How much do you want to withdraw?");
                                string withdrawAmount = Console.ReadLine();
                                double.TryParse(withdrawAmount, out double withdraw);
                                globalSavings.MakeWithdrawal(withdraw);
                                break;
                            case "C":
                                globalSavings.CloseAndReport();
                                break;
                            case "D":
                                Console.WriteLine("The balance in USD is: " + globalSavings.USValue(0.76));
                                break;
                            default:
                                break;
                        }
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
}
