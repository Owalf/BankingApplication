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
            GlobalSavingsAccount globalSavings = new GlobalSavingsAccount(5.00, .15);

            while (true)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Welcome to OmegaBank, please select an account type.");
                Console.WriteLine("A: Savings");
                Console.WriteLine("B: Checking");
                Console.WriteLine("C: GlobalSavings");
                Console.WriteLine("Q: Exit");
                string AccountType = Console.ReadLine();

                while (!(AccountType.ToUpper() == "A" || AccountType.ToUpper() == "B" || AccountType.ToUpper() == "C" || AccountType.ToUpper() == "Q"))
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("No such options, please select a valid option.");
                    AccountType = Console.ReadLine();
                }
                switch (AccountType.ToUpper())
                {
                    case "A":
                        Console.WriteLine("-----------------------------------------------------------");
                        Console.WriteLine("Savings Menu");
                        Console.WriteLine("A: Deposit");
                        Console.WriteLine("B: Withdraw");
                        Console.WriteLine("C: Close + Report");
                        Console.WriteLine("R: Return to Bank Menu");

                        string savingsOption = Console.ReadLine();

                        while (!(savingsOption.ToUpper() == "A" || savingsOption.ToUpper() == "B" || savingsOption.ToUpper() == "C" || savingsOption.ToUpper() == "R"))
                        {
                            Console.WriteLine("No such options, please select a valid option.");
                            savingsOption = Console.ReadLine();
                        }

                        switch (savingsOption.ToUpper())
                        {
                            case "A":
                                Console.WriteLine("\nHow much do you want to deposit?");
                                string depositAmount = Console.ReadLine();
                                while (!double.TryParse(depositAmount, out double enterADamnNumberPlease))
                                {
                                    Console.WriteLine("Enter a numeric value for the amount you deposit.");
                                    depositAmount = Console.ReadLine();
                                }
                                double.TryParse(depositAmount, out double deposit);
                                savings.MakeDeposit(deposit);
                                break;
                            case "B":
                                Console.WriteLine("\nHow much do you want to withdraw?");
                                string withdrawAmount = Console.ReadLine();
                                while (!double.TryParse(withdrawAmount, out double enterADamnNumberPlease))
                                {
                                    Console.WriteLine("Enter a numeric value for the amount you withdraw.");
                                    withdrawAmount = Console.ReadLine();
                                }
                                double.TryParse(withdrawAmount, out double withdraw);
                                savings.MakeWithdrawal(withdraw);
                                break;
                            case "C":
                                Console.WriteLine(savings.CloseAndReport());
                                break;
                            case "R":
                                break;
                            default:
                                break;
                        }
                        break;
                    case "B":
                        Console.WriteLine("-----------------------------------------------------------");
                        Console.WriteLine("Chequings Menu");
                        Console.WriteLine("A: Deposit");
                        Console.WriteLine("B: Withdraw");
                        Console.WriteLine("C: Close + Report");
                        Console.WriteLine("R: Return to Bank Menu");

                        string chequingOption = Console.ReadLine();

                        while (!(chequingOption.ToUpper() == "A" || chequingOption.ToUpper() == "B" || chequingOption.ToUpper() == "C" || chequingOption.ToUpper() == "R"))
                        {
                            Console.WriteLine("No such options, please select a valid option.");
                            chequingOption = Console.ReadLine();
                        }

                        switch (chequingOption.ToUpper())
                        {
                            case "A":
                                Console.WriteLine("\nHow much do you want to deposit?");
                                string depositAmount = Console.ReadLine();
                                while (!double.TryParse(depositAmount, out double enterADamnNumberPlease))
                                {
                                    Console.WriteLine("Enter a numeric value for the amount you deposit.");
                                    depositAmount = Console.ReadLine();
                                }
                                double.TryParse(depositAmount, out double deposit);
                                chequing.MakeDeposit(deposit);
                                break;
                            case "B":
                                Console.WriteLine("\nHow much do you want to withdraw?");
                                string withdrawAmount = Console.ReadLine();
                                while (!double.TryParse(withdrawAmount, out double enterADamnNumberPlease))
                                {
                                    Console.WriteLine("Enter a numeric value for the amount you withdraw.");
                                    withdrawAmount = Console.ReadLine();
                                }
                                double.TryParse(withdrawAmount, out double withdraw);
                                chequing.MakeWithdrawal(withdraw);
                                break;
                            case "C":
                                Console.WriteLine(chequing.CloseAndReport());
                                break;
                            case "R":
                                break;
                            default:
                                break;
                        }
                        break;
                    case "C":
                        Console.WriteLine("-----------------------------------------------------------");
                        Console.WriteLine("GlobalSavings Menu");
                        Console.WriteLine("A: Deposit");
                        Console.WriteLine("B: Withdraw");
                        Console.WriteLine("C: Close + Report");
                        Console.WriteLine("D: Report Balance in USD");
                        Console.WriteLine("R: Return to Bank Menu");

                        string globalSavingsOption = Console.ReadLine();

                        while (!(globalSavingsOption.ToUpper() == "A" || globalSavingsOption.ToUpper() == "B" || globalSavingsOption.ToUpper() == "C" || globalSavingsOption.ToUpper() == "D" || globalSavingsOption.ToUpper() == "R"))
                        {
                            Console.WriteLine("No such options, please select a valid option.");
                            globalSavingsOption = Console.ReadLine();
                        }

                        switch (globalSavingsOption.ToUpper())
                        {
                            case "A":
                                Console.WriteLine("\nHow much do you want to deposit?");
                                string depositAmount = Console.ReadLine();
                                while (!double.TryParse(depositAmount, out double enterADamnNumberPlease))
                                {
                                    Console.WriteLine("Enter a numeric value for the amount you deposit.");
                                    depositAmount = Console.ReadLine();
                                }
                                double.TryParse(depositAmount, out double deposit);
                                globalSavings.MakeDeposit(deposit);
                                break;
                            case "B":
                                Console.WriteLine("\nHow much do you want to withdraw?");
                                string withdrawAmount = Console.ReadLine();
                                while (!double.TryParse(withdrawAmount, out double enterADamnNumberPlease))
                                {
                                    Console.WriteLine("Enter a numeric value for the amount you withdraw.");
                                    withdrawAmount = Console.ReadLine();
                                }
                                double.TryParse(withdrawAmount, out double withdraw);
                                globalSavings.MakeWithdrawal(withdraw);
                                break;
                            case "C":
                                Console.WriteLine(globalSavings.CloseAndReport());
                                break;
                            case "D":
                                Console.WriteLine("The balance in USD is: " + ExtensionMethods.ToNAMoneyFormat(globalSavings.USValue(0.76), true));
                                break;
                            case "R":
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
