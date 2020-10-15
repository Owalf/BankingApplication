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
        protected double startingBalance;
        protected double currentBalance;
        protected double totalDepositAmount;
        protected int numberOfDeposit;
        protected double totalWithdrawalAmount;
        protected int numberOfWithdrawal;
        protected double annualInterestRate;
        protected double serviceCharge;
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

        public Account(double sbalance, double cbalance, double interestRate)
        {
            startingBalance = sbalance;
            currentBalance = cbalance;
            annualInterestRate = interestRate;
        }

        public void MakeDeposit(double amount)
        {
            numberOfDeposit++;
            currentBalance += amount;
        }

        public void MakeWithdrawal(double amount)
        {
            numberOfWithdrawal++;
            currentBalance -= amount;
        }

        public void CalculateInterest()
        {
            double monthlyInterestRate = annualInterestRate / 12;
            double monthlyInterest = currentBalance * monthlyInterestRate;
            double balance = currentBalance + monthlyInterest;
        }

        public string CloseAndReport()
        {
            currentBalance -= serviceCharge;

            CalculateInterest();


            numberOfDeposit = 0;
            numberOfWithdrawal = 0;
            serviceCharge = 0;

            string str;
            return str = "Previous balance: " + startingBalance +
                         "New balance: " + currentBalance +
                         "The variation % of change from the starting to the current balances: " + ((currentBalance - startingBalance) / startingBalance * 100) +
                         "More details: " + ""
                         ;
        }
    }
}
