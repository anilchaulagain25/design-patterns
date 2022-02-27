namespace design_patterns.Behavioural.Observer.Observers
{
    public class EmailService : Observer
    {
        public void notify(string stockSymbl, float price)
        {
            System.Console.WriteLine("Email sent to user: " + stockSymbl + " " + price);
        }

    }
}