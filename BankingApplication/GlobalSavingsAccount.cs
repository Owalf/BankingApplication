using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class GlobalSavingsAccount : SavingsAccount, IExchangeable
    {
        public GlobalSavingsAccount(double val1, double val2) : base(val1, val2) 
        { 
        }

        public double USValue(double rate)
        {
            return currentBalance * rate;
        }
    }
}
