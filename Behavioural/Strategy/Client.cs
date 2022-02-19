namespace design_patterns.Behavioural.Strategy
{
    public class Client
    {
        public static void Main()
        {
            Order order = new Order()
            {
                CustomerName = "John Doe"
            };
            order.AddItem(new OrderItem()
            {
                ProductName = "Bike",
                Quantity = 1,
                Price = 100
            });

            //Client passes the Strategy to the Order class
            PaymentStrategy paymentStrategy = new VisaPaymentStrategy();

            order.Pay(paymentStrategy);
        }


    }
}