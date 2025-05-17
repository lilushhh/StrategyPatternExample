using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    public class CheckoutContext
    {
        private IPaymentStrategy strategy;
        public void SetStrategy(IPaymentStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void ProcessPayment(double amount)
        {
            if(strategy == null)
            {
                Console.WriteLine("Error: No payment strategy selected!!");
                return;
            }
            strategy.Pay(amount);
        }
    }
}
