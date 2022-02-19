namespace design_patterns.Structural.Facade
{
    public class Client
    {

        public static void Main()
        {
            //Client calls to sinle API instead of multiple API's of the library
            BankingAPI bankingAPI = new();
            bankingAPI.PayLoanFromSavingAccount("LN-123", "SV-123", 10000);
        }
    }
}