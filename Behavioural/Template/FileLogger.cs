namespace design_patterns.Behavioural.Template
{
    public class FileLogger : Logger
    {
        public override void CloseConnection()
        {
            System.Console.WriteLine("Closing file logger");
        }

        public override void OpenConnection()
        {
            System.Console.WriteLine("Opening file logger");
        }

        public override void Write(string exception)
        {
            System.Console.WriteLine("Writing to file logger");
        }
    }
}