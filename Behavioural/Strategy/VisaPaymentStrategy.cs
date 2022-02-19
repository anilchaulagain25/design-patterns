namespace design_patterns.Behavioural.Strategy
{
    public class VisaPaymentStrategy : PaymentStrategy
    {
        public void Pay(double amount)
        {
            // Visa payment implementation
            Console.WriteLine($"Paying {amount} using Visa");
        }
    }
}