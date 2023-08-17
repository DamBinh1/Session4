using System;
namespace laptrinhApc.session4
{
    public class Customer
    {
        public string CustomerCode { get; set; }
        public string FullName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public double Quantity { get; set; }
        

        public virtual double CalculateTotalAmount()
        {
            return Quantity * 1000;
        }
    }


    class VietnameseCustomer : Customer
    {
        public string CustomerType { get; set; }

        public override double CalculateTotalAmount()
        {
            double totalAmount = 0;
            double threshold = 200;

            if (Quantity <= threshold)
            {
                if (Quantity <= 50)
                {
                    totalAmount = Quantity * 1000;
                }
                else if (Quantity <= 100)
                {
                    totalAmount = 50 * 1000 + (Quantity - 50) * 1200;
                }
                else if (Quantity <= 200)
                {
                    totalAmount = 50 * 1000 + 50 * 1200 + (Quantity - 100) * 1500;
                }
            }
            else
            {
                totalAmount = 50 * 1000 + 50 * 1200 + 100 * 1500 + (Quantity - 200) * 2000;
            }

            return totalAmount;
        }
    }

    class ForeignCustomer : Customer
    {
        public string Nationality { get; set; }

        public override double CalculateTotalAmount()
        {
            return Quantity * 2000;
        }
    }
}
