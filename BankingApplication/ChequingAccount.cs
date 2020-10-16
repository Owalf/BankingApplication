﻿using System;
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
            Console.WriteLine("You have successfully deposited " + amount + "$ to your chequing account.\nYour current balance is now " + currentBalance + "$");
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
                Console.WriteLine("You have successfully withdrawn " + amount + "$ from your chequing account.\nYour current balance is now " + currentBalance + "$");
            }
        }

        public void CloseAndReport()
        {
            serviceCharge = 0.1 * numberOfWithdrawal + 5;
            base.CloseAndReport();
        }
    }
}
