using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_4_12
{
    public class Invoice
    {
        private string partNumber, partDescription;
        private int quantity;
        private decimal pricePerItem;

        public string PartNumber// property
        {
            get
            {
                return partNumber;
            }
            set
            {
                partNumber = value;
            }
        }

        public string PartDescription// property
        {
            get
            {
                return partDescription;
            }
            set
            {
                partDescription = value;
            }
        }

        public int Quantity// property
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value >= 0)
                    quantity = value;
                else
                    quantity = 0;
            }
        }

        public decimal PricePerItem// property
        {
            get
            {
                return pricePerItem;
            }
            set
            {
                if (value >= 0)
                    pricePerItem = value;
                else
                    pricePerItem = 0;
            }
        }

        public Invoice(string initalNumber, string initialDescription, int initialQauntity, decimal initialPrice) // contructor
        {
            PartNumber = initalNumber;
            PartDescription = initialDescription;
            Quantity = initialQauntity;
            PricePerItem = initialPrice;
        }

        public decimal GetInvoiceAmount()
        {
            decimal invoiceAmount = Quantity * Convert.ToDecimal(PricePerItem);
            return invoiceAmount;
        }

        public void Display()
        {
            Console.WriteLine("Part Number: " + PartNumber);
            Console.WriteLine("Part Description: " + PartDescription);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Price Per Item: " + PricePerItem);
            Console.WriteLine("\n");
        }
    }
}
