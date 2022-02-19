namespace design_patterns.Behavioural.Template
{
    public class DbLogger : Logger
    {
        public override void CloseConnection()
        {
            System.Console.WriteLine("Closing db logger");
        }

        public override void OpenConnection()
        {
            System.Console.WriteLine("Opening db logger");
        }

        public override void Write(string exception)
        {
            System.Console.WriteLine("Writing to db logger");
        }
    }
}