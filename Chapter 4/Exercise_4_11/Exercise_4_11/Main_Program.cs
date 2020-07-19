using System;

namespace Exercise_4_11
{
    public class Main_Program
    { 
        public static void Main(string[] args)
        {
            Account account1 = new Account(34M,"Leandro");
            Account account2 = new Account(-34M,"Lima");
            decimal depositAmount;


            // display initial balance of each object using a property
            account1.Display();
            account2.Display();
            
            // depositing
            Console.Write("Amount to be deposit in " + account1.Name + " :");
            account1.Credit(Convert.ToDecimal(Console.ReadLine()));

            Console.Write("Amount to be deposit in " + account2.Name + " :");
            account2.Credit(Convert.ToDecimal(Console.ReadLine()));


            // display balance of each object using a property
            account1.Display();

            account2.Display();


            // withdrawing
            Console.Write("Amount to be whitdraw in " + account1.Name + " :");
            account1.Debit(Convert.ToDecimal(Console.ReadLine()));

            Console.Write("Amount to be whitdraw in " + account2.Name + " :");
            account2.Debit(Convert.ToDecimal(Console.ReadLine()));

            // display balance of each object using a property
            account1.Display();

            account2.Display();
        }
    }
}
