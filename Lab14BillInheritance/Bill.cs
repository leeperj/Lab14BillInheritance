using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14BillInheritance
{
    class Bill
    {
        public double Subtotal { get; set; }
        public double TaxRate { get; set; }

        public Bill()
        {

        }

        public Bill(double subtotal, double taxrate)
        {

        }
        public virtual double CalcTotal()
        {
            double total = Subtotal * (1 + TaxRate);
            return total;
        }

    }
}
