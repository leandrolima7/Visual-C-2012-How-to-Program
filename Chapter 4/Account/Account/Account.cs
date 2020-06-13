using System;

namespace Account
{
    public class Account
    {
        private decimal balance; //instance variable balance
        private string name; //instance variable name

        public Account(decimal initialBalance, string name) //Constructor 
        {
            Balance = initialBalance;
            Name = name;
        }


            
        public void Credit(decimal amount) //Method credit to make the balance up to date
        {
            Balance = Balance + amount; //if amout is negative it takes credit fo the balance
        }

        public decimal Balance  //Property to the instance variable balance
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
                    Console.WriteLine("Impossible to assign negative values");
            }
        }

        public string Name  //Property to the instance variable name
        {
            get
            {
                return name;
            }
            set
            {
                if (String.IsNullOrEmpty(name))
                    name = value;
                else
                    Console.WriteLine("Impossible to reassign name");
            }
        }
    }
}
