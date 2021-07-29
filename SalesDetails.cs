using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class SalesDetails
    {
        int Salesno { get; set; }
        int Productno { get; set; }
        float price { get; set; }
        DateTime dateofsale { get; set; }
        int qty { get; set; }
        float TotalAmount { get; set; }

        public void Sale(int qty, float price)
        {
            this.qty = qty;
            this.price = price;
            this.TotalAmount = qty * price;
        }

        SalesDetails(int Salesno, int Productno, DateTime dateofsale, int price, int qty)
        {
            this.Salesno = Salesno;
            this.Productno = Productno;
            this.dateofsale = dateofsale;
            this.price = price;
            this.qty = qty;
            TotalAmount = 0;

        }
        public void Display()
        {
            Console.WriteLine("Salesno: {0} Productno: {1} dateofsale: {2} price:{3} qty:{4} TotalAmount: {5}",
                Salesno, Productno, dateofsale, price, qty, TotalAmount);
        }
        static void Main()
        {
            SalesDetails s = new SalesDetails(1, 1, Convert.ToDateTime("2021-10-02"), 0, 0);
            s.Display();
            s.Sale(2, 20);
            s.Display();

        }
    }
}
