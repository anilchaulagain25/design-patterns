namespace design_patterns.Behavioural.Observer
{
    public class StockService : Subject
    {
        public void updateStockPrice(string stockSymbl, float price)
        {
            //some update logic to database or external service

            //Notify the observer that stock price is changed
            Notify(stockSymbl, price);
        }
    }
}