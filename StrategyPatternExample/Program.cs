using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var checkout = new CheckoutContext();

            checkout.SetStrategy(new CreditCardPayment());
            checkout.ProcessPayment(200);

            Console.WriteLine("---------------------");

            checkout.SetStrategy(new PayPalPayment());
            checkout.ProcessPayment(400);

            Console.WriteLine("---------------------");

            checkout.SetStrategy(new BitPayment());
            checkout.ProcessPayment(300);

            Console.WriteLine("---------------------");

            checkout.SetStrategy(new CashPayment());
            checkout.ProcessPayment(150);
        }
    }
}
