using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptrinhApc.demo4
{
    public delegate void UpdateQtyHandler(int n);
    public class Product
    {
        private int qty;
        public event UpdateQtyHandler qtyChanged ;
        public Product()
        {
            
        }
        public int Qty
        {
            get => qty;
            set => qty = value; 
        }
        public void NotifyChangedQty(int n)
        {
            Console.WriteLine("Qty of product was changed" + n);
        }
        public void SendEmailToAdmin(int n)
        {

        }
        public void 
        public void inscreenQty(int q)
        {
            if (q > 0)
            {
                qty += q;
                qtyChanged(q);
                SendEmail
            }
        }
    }
}
