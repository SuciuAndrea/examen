using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class Order
    {

        
            public string Customer { get; set; }
            public DateTime Date { get; set; }
            public decimal Total { get; set; }

            public Order(string customer, DateTime date, decimal total)
            {
                Customer = customer;
                Date = date;
                Total = total;
            }
        public void PaymentSystem( paymentMethod)
        {
            Console.WriteLine($"Processing payment");
            paymentMethod.ProcessPayment(Total);
            Console.WriteLine("Payment processed successfully.");
        }
    }




}
}
