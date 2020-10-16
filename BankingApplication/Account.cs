﻿using System;
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

            string str = "\nPrevious balance: " + startingBalance +
                         "$\nNew balance: " + currentBalance +
                         "$\nThe percentage of change from the starting balance to the current balance: " + ((currentBalance - startingBalance) / startingBalance * 100) +
                         "%\nMore details: \n" + "Number of withdrawals: " + numberOfWithdrawal;
            return str;
        }

        public virtual double getPercentageChange() {

            return ((currentBalance) / startingBalance * 100);


        }

        public virtual uint toNAMoneyFormat(bool RoundUp, bool RoundDown)
        {
            if(RoundUp = true)
            {
                double value = Math.Round(currentBalance);


                string formatted = value.ToString("{0:C}");
                uint vOut = Convert.ToUInt32(formatted);

                return vOut;
            }
            else
            {
                return ;
            }
        }
    }
}
