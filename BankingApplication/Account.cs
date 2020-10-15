using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    abstract class Account : IAccount
    {
        double startingBalance;
        double currentBalance;
        double totalDepositAmount;
        int numberOfDeposit;
        double totalWithdrawalAmount;
        int numberOfWithdrawal;
        double annualInterestRate;
        double serviceCharge;
        enum Status
        {
            Active,
            Inactive
        }

        public double StartingBalance
        {
            get { return startingBalance; }
            set { startingBalance = value; }
        }

        public double CurrentBalance
        {
            get { return currentBalance; }
            set { currentBalance = value; }
        }

        public Account(double sbalance, double cbalance, double interestRate)
        {
            startingBalance = sbalance;
            currentBalance = cbalance;
            annualInterestRate = interestRate;
        }

        void IAccount.MakeDeposit(double amount)
        {
            numberOfDeposit++;
            currentBalance += amount;
        }

        void IAccount.MakeWithdrawal(double amount)
        {
            numberOfWithdrawal++;
            currentBalance -= amount;
        }

        void IAccount.CalculateInterest()
        {
            double monthlyInterestRate = annualInterestRate / 12;
            double monthlyInterest = currentBalance * monthlyInterestRate;
            double balance = currentBalance + monthlyInterest;
        }

        string IAccount.CloseAndReport()
        {
            currentBalance -= serviceCharge;
            CalculateInterest();

            string str;

            numberOfDeposit = 0;
            numberOfWithdrawal = 0;

        }
    }
}
