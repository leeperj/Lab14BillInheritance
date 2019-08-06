using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14BillInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill()
            {
                Subtotal = 15.80,
                TaxRate = 0.06
            };

            Pay(bill);

            TippableBill tippableBill = new TippableBill()
            {
                Subtotal = 8.50,
                TaxRate = 0.06,
                Tip = 2.00,
            };

            Pay(tippableBill);
        }
        public static void Pay(Bill bill)
        {
            double newBill = bill.CalcTotal();
            Console.WriteLine($"${newBill}");
        }
    }
}
