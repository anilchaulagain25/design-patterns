namespace design_patterns.Structural.Facade
{
    public static class TestData
    {
        public static List<SavingAccount> SavingAccounts
        {
            get
            {
                return new List<SavingAccount>{
                new SavingAccount("SV-123", "Saving Account 1", 10000),
                new SavingAccount("SV-124", "Saving Account 2", 20000),
                new SavingAccount("SV-125", "Saving Account 3", 30000),
                new SavingAccount("SV-126", "Saving Account 4", 40000),
                new SavingAccount("SV-127", "Saving Account 5", 50000),
                new SavingAccount("SV-128", "Saving Account 6", 60000),
                new SavingAccount("SV-129", "Saving Account 7", 70000),
                new SavingAccount("SV-130", "Saving Account 8", 80000),
                new SavingAccount("SV-131", "Saving Account 9", 90000),
                new SavingAccount("SV-132", "Saving Account 10", 100000)
            };
            }
        }
        public static List<LoanAccount> LoanAccounts
        {
            get
            {
                return new List<LoanAccount>{
                new LoanAccount("LN-123", "Loan Account 1", 10000),
                new LoanAccount("LN-124", "Loan Account 2", 20000),
                new LoanAccount("LN-125", "Loan Account 3", 30000),
                new LoanAccount("LN-126", "Loan Account 4", 40000),
                new LoanAccount("LN-127", "Loan Account 5", 50000),
                new LoanAccount("LN-128", "Loan Account 6", 60000),
                new LoanAccount("LN-129", "Loan Account 7", 70000),
                new LoanAccount("LN-130", "Loan Account 8", 80000),
                new LoanAccount("LN-131", "Loan Account 9", 90000),
                new LoanAccount("LN-132", "Loan Account 10", 100000)
                };
            }
        }

    }
}