namespace design_patterns.Behavioural.Observer.Observers
{
    public class SMSService : Observer
    {
        public void notify(string stockSymbl, float price)
        {
            System.Console.WriteLine("Email SMS to user: " + stockSymbl + " " + price);
        }
    }
}