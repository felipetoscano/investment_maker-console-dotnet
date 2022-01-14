namespace InvestmentMaker
{
    public class Account
    {
        public double Balance { get; private set; }

        public Account()
        {

        }

        public Account(double initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(double value)
        {
            Balance += value;
        }
    }
}
