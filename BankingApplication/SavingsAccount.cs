using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class SavingsAccount : Account, IAccount
    {
        public SavingsAccount(double val1, double val2) : base(val1, val2)
        {
            startingBalance = val1;
            annualInterestRate = val2;
        }
        public override void MakeDeposit(double amount)
        {
            if(CurrentBalance + amount >= 25)
            {
                Status pos = Status.Active;
                base.MakeDeposit(amount);

                Console.WriteLine("You have successfully deposited " + amount + "$ to your savings account.\nYour current balance is now " + currentBalance + "$");
            }
            else
            {
                Status pos = Status.Inactive;
                Console.WriteLine("Account is Inactive");
                base.MakeDeposit(amount);
                Console.WriteLine("You have successfully deposited " + amount + "$ to your savings account.\nYour current balance is now " + currentBalance + "$");
            }
            
        }

        public override void MakeWithdrawal(double amount)
        {
            if(CurrentBalance - amount >= 25)
            {
                Status pos = Status.Active;
                base.MakeWithdrawal(amount);
                Console.WriteLine("You have successfully withdrawn " + amount + "$ from your savings account.\nYour current balance is now " + currentBalance + "$");
            }
            else
            {
                Status pos = Status.Inactive;
                base.MakeWithdrawal(amount);
                Console.WriteLine("You have successfully withdrawn " + amount + "$ from your savings account.\nYour current balance is now " + currentBalance + "$");
            }
        }

        public override string CloseAndReport()
        {
            if(numberOfWithdrawal > 4)
            {
                serviceCharge += 1;
                return base.CloseAndReport();
            }
            else
            {
                return base.CloseAndReport();
            }
        }
    }
}
