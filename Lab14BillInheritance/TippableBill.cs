using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14BillInheritance
{
    class TippableBill : Bill
    {
        public double Tip { get; set; }

        public TippableBill()
        {

        }

        public TippableBill(double tip, double subtotal, double taxRate)
            : base(subtotal, taxRate)
        {
            Tip = tip;
            Subtotal = subtotal;
            TaxRate = taxRate;
        }

        public override double CalcTotal()
        {

            double total = (Subtotal * (1 + TaxRate));
            total += Tip;
            
            return total;
        }
    }
}
