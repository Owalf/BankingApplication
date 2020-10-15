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
                base.MakeDeposit(amount);
            }
            else
            {
                base.MakeDeposit(amount);
            }
            
        }

        public void MakeWithdrawal(double amount)
        {
            if(CurrentBalance - amount > 25)
            {
                base.MakeWithdrawal(amount);
            }
            else
            {
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
