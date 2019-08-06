using System;

namespace Lab14BillInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill myBill = new Bill(15.80, 0.06);
            Pay(myBill);
            Bill myBillWithTip = new TippableBill(2.00, 8.50, 0.06);
            Pay(myBillWithTip);
            

        }

        public static void Pay(Bill input)
        {
            Console.WriteLine($"${input.CalcTotal()}");
        }
    }

}
