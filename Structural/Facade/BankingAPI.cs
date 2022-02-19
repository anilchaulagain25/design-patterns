namespace design_patterns.Structural.Facade
{
    public class BankingAPI
    {
        public void PayLoanFromSavingAccount(string loanAccountNo, string savingAccountNo, double amount)
        {
            //Get Saving Account
            SavingAccount savingAccount = TestData.SavingAccounts.First(x => x.AccountNo == savingAccountNo);
            savingAccount.Withdraw(amount);
            System.Console.WriteLine("Withdraw from Saving Account: " + savingAccount.AccountNo + " - Rs." + amount);

            //Get Loan Account
            LoanAccount loanAccount = TestData.LoanAccounts.First(x => x.AccountNo == loanAccountNo);
            loanAccount.PayLoan(amount);
            System.Console.WriteLine("Pay Loan from Loan Account: " + loanAccount.AccountNo + " - Rs." + amount);
        }
    }
}