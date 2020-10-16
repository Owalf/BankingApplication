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
            currentBalance += startingBalance;
            annualInterestRate = interestRate;
        }

        public virtual void MakeDeposit(double amount)
        {
            numberOfDeposit++;
            totalDepositAmount += amount;
            currentBalance += amount;

        }

        public virtual void MakeWithdrawal(double amount)
        {
            numberOfWithdrawal++;
            totalWithdrawalAmount += amount;
            currentBalance -= amount;
        }

        public virtual void CalculateInterest()
        {
            double monthlyInterestRate = annualInterestRate / 12;
            double monthlyInterest = currentBalance * monthlyInterestRate;
            double balance = currentBalance + monthlyInterest;

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Interest Information");
            Console.WriteLine("The monthly interest: " + ExtensionMethods.ToNAMoneyFormat(monthlyInterest, true));
            Console.WriteLine("The current balance with monthly interest: " + ExtensionMethods.ToNAMoneyFormat(balance, true));
            Console.WriteLine("-----------------------------------------------------------");
        }

        public virtual string CloseAndReport()
        {
            currentBalance -= serviceCharge;

            CalculateInterest();
            Console.WriteLine("Close + Report Information\nMonthly Service Charge: " + ExtensionMethods.ToNAMoneyFormat(serviceCharge, true));
            numberOfDeposit = 0;
            numberOfWithdrawal = 0;
            serviceCharge = 0;

            string str = "Previous balance: " + ExtensionMethods.ToNAMoneyFormat(startingBalance, true) +
                         "\nNew balance: " + ExtensionMethods.ToNAMoneyFormat(currentBalance, true) +
                         "\nThe percentage of change from the starting balance to the current balance: " + getPercentageChange() +
                         "%\nTotal amount deposited this month: " + ExtensionMethods.ToNAMoneyFormat(totalDepositAmount, true) +
                         "\nTotal amount withdrawn this month: " + ExtensionMethods.ToNAMoneyFormat(totalWithdrawalAmount, true);
            return str;
        }

        public double getPercentageChange() 
        {
            return (currentBalance - startingBalance) / startingBalance * 100;
        }
    }
}
