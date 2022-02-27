using design_patterns.Behavioural.Observer.Observers;

namespace design_patterns.Behavioural.Observer
{
    public class Client
    {
        public static void Main()
        {
            StockService stockService = new StockService();

            //Registering observers
            stockService.Attach(new EmailService());
            stockService.Attach(new LoggingService());
            stockService.Attach(new SMSService());

            stockService.updateStockPrice("IBM", 100);
        }
    }
}