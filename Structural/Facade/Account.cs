namespace design_patterns.Structural.Facade
{
    public abstract class Account
    {
        private string _acNo;
        private string _name;
        protected double _balance;

        public Account(string acNo, string name, double balance)
        {
            _acNo = acNo;
            _name = name;
            _balance = balance;
        }
        public decimal Balance
        {
            get { return (decimal)_balance; }
        }
        public string AccountNo
        {
            get { return _acNo; }
        }
    }

    public class SavingAccount : Account
    {
        public SavingAccount(string acNo, string name, double balance) : base(acNo, name, balance)
        {
        }

        public void Deposit(double amount)
        {
            this._balance += amount;
        }
        public void Withdraw(double amount)
        {
            this._balance -= amount;
        }
    }
    public class LoanAccount : Account
    {
        public LoanAccount(string acNo, string name, double balance) : base(acNo, name, balance)
        {

        }
        public void DisburseLoan(double amount)
        {
            this._balance -= amount;
        }
        public void PayLoan(double amount)
        {
            this._balance = amount;
        }
    }
}