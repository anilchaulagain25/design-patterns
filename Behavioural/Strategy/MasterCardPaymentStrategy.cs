namespace design_patterns.Behavioural.Strategy
{
    public class MasterCardPaymentStrategy : PaymentStrategy
    {
        public void Pay(double amount)
        {
            // MasterCard payment implementation
            Console.WriteLine($"Paying {amount} using MasterCard");
        }
    }
}