// BAD CODE — Violates SRP, OCP, and LSP
// This class handles validation, payment logic, method selection,
// and logging all in one place.

using System;

namespace BadPaymentExample
{
    public class PaymentService
    {
        public void ProcessPayment(string method, double amount)
        {
            // Bad: Validation inside the same class
            Console.WriteLine("Validating payment...");

            // Bad: Method-specific logic hardcoded
            if (method == "CreditCard")
            {
                Console.WriteLine($"Processing credit card payment: ${amount}");
            }
            else if (method == "PayPal")
            {
                Console.WriteLine($"Processing PayPal payment: ${amount}");
            }
            else
            {
                Console.WriteLine("Unsupported payment method!");
            }

            // Bad: Logging inside the same class
            Console.WriteLine("Payment has been logged.");
        }
    }
}
