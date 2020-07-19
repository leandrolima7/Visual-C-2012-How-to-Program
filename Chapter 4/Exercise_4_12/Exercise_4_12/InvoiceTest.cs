using System;

namespace Exercise_4_12
{
    public class InvoiceTest
    {
        public static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice("234", "Mouse", 3, 2.29M);
            Invoice invoice2 = new Invoice("14", "Keyboard", 13, 4.5M);

            //display
            invoice1.Display();
            invoice2.Display();

            //amout
            Console.Write("Invoice amount of "+invoice1.PartNumber + " product: "+ invoice1.GetInvoiceAmount() + "\n");
           

            Console.Write("Invoice amount of " + invoice2.PartNumber + " product: " + invoice2.GetInvoiceAmount()+"\n");
            invoice2.GetInvoiceAmount();

        }
    }
}
