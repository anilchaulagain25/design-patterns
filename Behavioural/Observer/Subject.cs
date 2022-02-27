namespace design_patterns.Behavioural.Observer
{
    public abstract class Subject
    {
        private readonly List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }
        //remove observer
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }
        //notify observers
        public void Notify(string stockSymbl, float price)
        {
            foreach (var observer in _observers)
            {
                observer.notify(stockSymbl, price);
            }
        }
    }
}