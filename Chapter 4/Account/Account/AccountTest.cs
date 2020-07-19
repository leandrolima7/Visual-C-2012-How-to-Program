using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Account
{
    public class AccountTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(-7.33M, "Leandro"); //Creating account 1
            Account account2 = new Account(17.13M, "Silva"); //Creating account 2

            Console.WriteLine("Balance of "+account1.Name +": "+ account1.Balance);

            Console.WriteLine();
            
            Console.WriteLine("Balance of " + account2.Name + ": " + account2.Balance);

            Console.WriteLine();
            Console.WriteLine();

            decimal deposit;

            Console.Write("Enter deposit amount for " + account1.Name + ": ");
            deposit = Convert.ToDecimal(Console.ReadLine());
            account1.Credit(deposit);
            Console.Write(deposit + " has been added to " + account1.Name + "'s account");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter deposit amount for " + account2.Name + ": ");
            deposit = Convert.ToDecimal(Console.ReadLine());
            account2.Credit(deposit);
            Console.Write(deposit + " has been added to " + account2.Name + "'s account");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Balance of " + account1.Name + "'s account is: "+account1.Balance);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Balance of " + account2.Name + "'s account is: " + account2.Balance);
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
