namespace design_patterns.Behavioural.Template
{
    public class Client
    {
        // When two or more classes have common algorithm with similar steps,
        // then we can use Template Method Pattern. We move common method into (abstract) base class.
        // Create abstract method for the behavior that are different in different subclasses.
        public static void Main()
        {
            Logger dbLogger = new DbLogger();
            dbLogger.Log(new Exception("Error"));

            Logger fileLogger = new FileLogger();
            fileLogger.Log(new Exception("Error"));
        }
    }
}