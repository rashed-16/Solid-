using System;

namespace SolidPaymentSystem
{
    // ABSTRACT BASE CLASS — Supports OCP + LSP
   
    // All payment methods must inherit from this base class.
    // LSP: Any subclass can replace PaymentMethod safely.
    // OCP: Adding new payment methods requires no changes to existing code.
    public abstract class PaymentMethod
    {
        public abstract void Pay(double amount);
    }

   
    // CREDIT CARD PAYMENT — SRP
  
    // This class is responsible ONLY for credit card payment logic.
    public class CreditCardPayment : PaymentMethod
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"[CreditCard] Processing payment: ${amount}");
        }
    }

  
    // PAYPAL PAYMENT — SRP
  
    // This class is responsible ONLY for PayPal payment logic.
    public class PayPalPayment : PaymentMethod
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"[PayPal] Processing payment: ${amount}");
        }
    }

    // PAYMENT PROCESSOR — SRP + OCP

    // SRP: Only responsible for handling the payment flow.
    // OCP: Works with any PaymentMethod (current or future)
    //      without changing this class.
    public class PaymentProcessor
    {
        public void Process(PaymentMethod method, double amount)
        {
            method.Pay(amount);
            Console.WriteLine("Payment completed successfully.\n");
        }
    }
}
