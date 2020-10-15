using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class SavingsAccount : Account, IAccount
    {
        public override void makeWithdraw()
        {
            if (!Account.Status = "Inactive")
            {

            }

            else
                return "Unable to make a withdrawal";
        }

    
    }
}
