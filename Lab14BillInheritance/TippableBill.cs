using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14BillInheritance
{
    class TippableBill : Bill
    {
       public double Tip { get; set; }

        public TippableBill()
        {

        }

        public TippableBill(double subtotal, double taxRate, double tip)
        {

        }

        public override double CalcTotal()
        {
            double total = Subtotal * (1 + TaxRate);
            double totalWithTip = total + Tip;
            return totalWithTip;

        }



    }
}
