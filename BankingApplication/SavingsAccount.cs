using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class SavingsAccount : Account, IAccount
    {
        public SavingsAccount(double val1, double val2) : base(val1, val2)
        {
        }
        public override void MakeDeposit(double amount)
        {
            if(currentBalance + amount >= 25)
            {
                Status pos = Status.Active;
                base.MakeDeposit(amount);
                Console.WriteLine("You have successfully deposited " + ExtensionMethods.ToNAMoneyFormat(amount, true) + " to your savings account.\nYour current balance is now " + ExtensionMethods.ToNAMoneyFormat(currentBalance, true) + "\nNumber of deposits: " + numberOfDeposit);
            }
            else
            {
                Status pos = Status.Inactive;
                Console.WriteLine("Account is Inactive");
                base.MakeDeposit(amount);
                Console.WriteLine("You have successfully deposited " + ExtensionMethods.ToNAMoneyFormat(amount, true) + " to your savings account.\nYour current balance is now " + ExtensionMethods.ToNAMoneyFormat(currentBalance, true) + "\nNumber of deposits: " + numberOfDeposit);
            }
            
        }

        public override void MakeWithdrawal(double amount)
        {
            if(currentBalance - amount >= 25)
            {
                Status pos = Status.Active;
                base.MakeWithdrawal(amount);
                Console.WriteLine("You have successfully withdrawn " + ExtensionMethods.ToNAMoneyFormat(amount, true) + " from your savings account.\nYour current balance is now " + ExtensionMethods.ToNAMoneyFormat(currentBalance, true) + "\nNumber of withdrawals: " + numberOfWithdrawal);
            }
            else
            {
                Status pos = Status.Inactive;
                base.MakeWithdrawal(amount);
                Console.WriteLine("You have successfully withdrawn " + ExtensionMethods.ToNAMoneyFormat(amount, true) + " from your savings account.\nYour current balance is now " + ExtensionMethods.ToNAMoneyFormat(currentBalance, true) + "\nNumber of withdrawals: " + numberOfWithdrawal);
            }
        }

        public override string CloseAndReport()
        {
            if(numberOfWithdrawal > 4)
            {
                serviceCharge = numberOfWithdrawal - 4;
                Console.WriteLine("Monthly Service Charge: " + ExtensionMethods.ToNAMoneyFormat(serviceCharge, true));
                return base.CloseAndReport();
            }
            else
            {
                Console.WriteLine("Monthly Service Charge: " + ExtensionMethods.ToNAMoneyFormat(serviceCharge, true));
                return base.CloseAndReport();

            }
        }
    }
}
