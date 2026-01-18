using System;

namespace CSharp
{
    class IFstatement
    {
        public static void Run()
        {
            Console.WriteLine("Enter Tax type (0 = Not Included, 1 = Included): ");
            int taxType = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter item price: ");
            double itemPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter item QTY: ");
            double itemQTY = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Tax value (%): ");
            double taxValue = Convert.ToDouble(Console.ReadLine());

            double priceBeforeTax;
            double taxAmount;
            double priceAfterTax;

            if (taxType == 0)
            {
                // السعر غير شامل الضريبة
                priceBeforeTax = itemPrice;
                taxAmount = itemPrice * taxValue / 100;
                priceAfterTax = (priceBeforeTax + taxAmount) * itemQTY;
            }
            else
            {
                // السعر شامل الضريبة
                priceAfterTax = itemPrice * itemQTY;
                priceBeforeTax = itemPrice / (1 + taxValue / 100) * itemQTY;
                taxAmount = priceAfterTax - priceBeforeTax;
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("Price Before Tax : " + priceBeforeTax.ToString("0.00"));
            Console.WriteLine("Tax Amount       : " + taxAmount.ToString("0.00"));
            Console.WriteLine("Final Price      : " + priceAfterTax.ToString("0.00"));
        }
    }
}
