using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankingApplication
{
    abstract class Account : IAccount
    {
        protected double startingBalance;
        protected double currentBalance;
        protected double totalDepositAmount;
        protected int numberOfDeposit;
        protected double totalWithdrawalAmount;
        protected int numberOfWithdrawal;
        protected double annualInterestRate;
        protected double serviceCharge = 0;

        protected enum Status
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

        public Account(double balance, double interestRate)
        {
            startingBalance = balance;
            annualInterestRate = interestRate;
        }

        public virtual void MakeDeposit(double amount)
        {
            numberOfDeposit++;
            currentBalance += amount;

        }

        public virtual void MakeWithdrawal(double amount)
        {
            numberOfWithdrawal++;
            currentBalance -= amount;
        }

        public virtual void CalculateInterest()
        {
            double monthlyInterestRate = annualInterestRate / 12;
            double monthlyInterest = currentBalance * monthlyInterestRate;
            double balance = currentBalance + monthlyInterest;
        }

        public virtual string CloseAndReport()
        {
            currentBalance -= serviceCharge;

            CalculateInterest();

            numberOfDeposit = 0;
            numberOfWithdrawal = 0;
            serviceCharge = 0;

            string str;
            return str = "Previous balance: " + startingBalance +
                         "\nNew balance: " + currentBalance +
                         "\nThe variation % of change from the starting to the current balances: " + ((currentBalance - startingBalance) / startingBalance * 100) +
                         "\nMore details: " + ""
                         ;
        }
    }
}
