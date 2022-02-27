namespace design_patterns.Behavioural.Observer.Observers
{
    public class LoggingService : Observer
    {
        public void notify(string stockSymbl, float price)
        {
            System.Console.WriteLine("Logging service: " + stockSymbl + " " + price);
        }
    }
}