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
        Status status = Status.Inactive;
        public SavingsAccount(double val1, double val2) : base(val1, val2)
        {
        }
        public override void MakeDeposit(double amount)
        {
            if(currentBalance + amount >= 25 && status == Status.Inactive)
            {
                base.MakeDeposit(amount);
                Console.WriteLine("You have successfully deposited " + ExtensionMethods.ToNAMoneyFormat(amount, true) + " to your savings account.\nYour current balance is now " + ExtensionMethods.ToNAMoneyFormat(currentBalance, true) + "\nNumber of deposits: " + numberOfDeposit);
                status = Status.Active;
            }
            else
            {
                base.MakeDeposit(amount);
                Console.WriteLine("You have successfully deposited " + ExtensionMethods.ToNAMoneyFormat(amount, true) + " to your savings account.\nYour current balance is now " + ExtensionMethods.ToNAMoneyFormat(currentBalance, true) + "\nNumber of deposits: " + numberOfDeposit);
            }
            
        }

        public override void MakeWithdrawal(double amount)
        {
            if(status == Status.Inactive)
            {
                Console.WriteLine("Nothing has been withdrawn because your account is inactive.\nYou need to have a balance of more than $25 to be able to withdraw.\nNumber of withdrawals: " + numberOfWithdrawal);
            }
            else
            {
                base.MakeWithdrawal(amount);
                Console.WriteLine("You have successfully withdrawn " + ExtensionMethods.ToNAMoneyFormat(amount, true) + " from your savings account.\nYour current balance is now " + ExtensionMethods.ToNAMoneyFormat(currentBalance, true) + "\nNumber of withdrawals: " + numberOfWithdrawal);
            }
        }

        public override string CloseAndReport()
        {
            if(numberOfWithdrawal > 4)
            {
                serviceCharge = numberOfWithdrawal - 4;
                return base.CloseAndReport();
            }
            else
            {
                return base.CloseAndReport();

            }
        }
    }
}
