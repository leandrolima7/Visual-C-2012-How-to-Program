using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Exercise_4_11
{
    public class Account
    {
        private decimal balance;
        private string name;

        public decimal Balance //property Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value >= 0)
                    balance = value;
                else
                {
                    balance = 0;
                    Console.WriteLine("Amount invalid! Please enter an amout greater then zero!");
                }
            }

        }

        public string Name //property Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Account (decimal initialBalance, string name) //Constructor
        {
            Balance = initialBalance;
            Name = name;
        }

        public void Credit (decimal amount) // credit (add) an amount to the account
        {
            Balance = Balance + amount;
        }

        public void Debit (decimal amount)//Debit (remove) an amount to the account
        {
            if (amount > balance)
                Console.WriteLine("Debit amount exceeded account balance");
            else
                Balance = Balance - amount;
        }

        public void Display()
        {
            Console.WriteLine("Amount of "+ Name + "' "+ "accoount: " + Balance);
        }
    }
}
