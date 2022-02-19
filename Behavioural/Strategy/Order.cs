namespace design_patterns.Behavioural.Strategy
{
    public class Order
    {
        public Order() => this.Items = new List<OrderItem>();

        public string CustomerName { get; set; }
        public List<OrderItem> Items { get; }

        public double TotalAmount()
        {
            return this.Items.Sum(x => x.Price);
        }

        public void Pay(PaymentStrategy paymentStrategy)
        {
            paymentStrategy.Pay(this.TotalAmount());
        }
        public void AddItem(OrderItem item)
        {
            this.Items.Add(item);
        }

        public bool RemoveItem(OrderItem item)
        {
            return this.Items.Remove(item);
        }
    }
    public class OrderItem
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}