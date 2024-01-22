using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class CreditCardPayment : PaymentSystem
    {
       
        
            public override void ProcessPayment(decimal amount)
            {
                Console.WriteLine($"Paid {amount} with credit card.");
               
            }
        
    }
}
