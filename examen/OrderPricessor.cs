using examen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class OrderPricessor
    {
        public void FulfillOrder(Order order, IPaymentSystem paymentSystem)
        {
            Console.WriteLine($"Processing order for customer {order.Customer} on {order.Date} with total amount: {order.Total}");
            paymentSystem.ProcessPayment(order.Total);
            Console.WriteLine("Order fulfilled successfully.");
        }
    }
}
OrderProcessor orderProcessor = new OrderProcessor();
orderProcessor.FulfillOrder(order, paymentSystem);
