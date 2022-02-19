namespace design_patterns.Behavioural.Template
{
    public abstract class Logger
    {
        public abstract void OpenConnection();
        public abstract void CloseConnection();
        public abstract void Write(string exception);


        public void Log(Exception message)
        {
            OpenConnection();
            Write(serializeException(message));
            CloseConnection();
        }
        public string serializeException(Exception message)
        {
            return message.Message + " " + message.StackTrace;
        }
    }
}