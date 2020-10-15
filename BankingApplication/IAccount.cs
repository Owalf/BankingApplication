using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    interface IAccount
    {
        void MakeWithdrawal(double amount);
        void MakeDeposit(double amount);
        void CalculateInterest();
        string CloseAndReport();
    }
}
