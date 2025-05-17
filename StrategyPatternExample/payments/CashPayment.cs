using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    public class CashPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} NIS in Cash Payment.");
        }
    }
}
