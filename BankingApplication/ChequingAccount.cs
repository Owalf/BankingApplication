using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class ChequingAccount : Account, IAccount
    {
        Status status = Status.Active;
        public ChequingAccount(double val1, double val2) : base(val1, val2)
        {
        }

        public override void MakeDeposit(double amount)
        {
            if(currentBalance + amount > 0)
            {
                base.MakeDeposit(amount);
                Console.WriteLine("You have successfully deposited " + ExtensionMethods.ToNAMoneyFormat(amount, true) + " to your chequing account.\nYour current balance is now " + ExtensionMethods.ToNAMoneyFormat(currentBalance, true) + "\nNumber of deposits: " + numberOfDeposit);
                status = Status.Active;
            }
        }

        public override void MakeWithdrawal(double amount)
        {
            if (currentBalance - amount < 0 && status == Status.Active)
            {
                serviceCharge = 15;
                currentBalance -= serviceCharge;
                Console.WriteLine("Nothing has been withdrawn because the balance will go under $0, a service fee of " + ExtensionMethods.ToNAMoneyFormat(serviceCharge, true) + " will be taken from your account.\nYour current balance is now " + ExtensionMethods.ToNAMoneyFormat((currentBalance), true) + "\nNumber of withdrawals: " + numberOfWithdrawal);
                status = Status.Inactive;
            }
            else if(status == Status.Inactive)
            {
                Console.WriteLine("Nothing has been withdrawn, your balance is in the negative");
            }
            else
            {
                base.MakeWithdrawal(amount);
                Console.WriteLine("You have successfully withdrawn " + ExtensionMethods.ToNAMoneyFormat(amount, true) + " from your chequing account.\nYour current balance is now " + ExtensionMethods.ToNAMoneyFormat(currentBalance, true) + "\nNumber of withdrawals: " + numberOfWithdrawal);
            }
        }

        public override string CloseAndReport()
        {
            serviceCharge += 0.1 * numberOfWithdrawal + 5;
            return base.CloseAndReport();
        }
    }
}