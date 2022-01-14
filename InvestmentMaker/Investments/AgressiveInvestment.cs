using InvestmentMaker;

namespace ImpostosStrategyPattern
{
    public class AgressiveInvestment : IInvestment
    {
        public double Invest(Account account)
        {
            int luck = new Random().Next(0, 100);

            if (luck >= 80)
            {
                return account.Balance * 0.05;
            }
            else if (luck >= 50)
            {
                return account.Balance * 0.03;
            }
            else
            {
                return account.Balance * 0.006;
            }
        }
    }
}
