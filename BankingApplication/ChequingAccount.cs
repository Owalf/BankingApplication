using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class ChequingAccount : Account, IAccount
    {
        public ChequingAccount(double val1, double val2) : base(val1, val2)
        {
        }

        public void MakeDeposit(double amount)
        {
            Status pos = Status.Active;
            base.MakeDeposit(amount);
        }

        public void MakeWithdrawal(double amount)
        {
            if (CurrentBalance - amount < 0)
            {
                Status pos = Status.Inactive;
                currentBalance -= 15;
                Console.WriteLine("Nothing has been withdrawn because the balance is under 0$.");
            }
            else
            {
                base.MakeWithdrawal(amount);
            }
        }

        public void CloseAndReport()
        {
            serviceCharge += 5;
            serviceCharge += 0.1;
            base.CloseAndReport();
        }
    }
}
