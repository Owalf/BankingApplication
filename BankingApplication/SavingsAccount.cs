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
        }
        public void MakeDeposit(double amount)
        {
            if(CurrentBalance + amount > 25)
            {
                Status pos = Status.Active;
                base.MakeDeposit(amount);
            }
            else
            {
                Status pos = Status.Inactive;
                base.MakeDeposit(amount);
            }
            
        }

        public void MakeWithdrawal(double amount)
        {
            if(CurrentBalance - amount > 25)
            {
                Status pos = Status.Active;
                base.MakeWithdrawal(amount);
            }
            else
            {
                Status pos = Status.Inactive;
                base.MakeWithdrawal(amount);
            }
        }

        public void CloseAndReport()
        {
            if(numberOfWithdrawal > 4)
            {
                serviceCharge += 1;
                base.CloseAndReport();
            }
            else
            {
                base.CloseAndReport();
            }
        }
    }
}
