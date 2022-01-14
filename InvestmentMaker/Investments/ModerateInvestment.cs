using InvestmentMaker;

namespace ImpostosStrategyPattern
{
    public class ModerateInvestment : IInvestment
    {
        public double Invest(Account account)
        {
            int luck = new Random().Next(0, 100);

            if (luck >= 50)
            {
                return account.Balance * 0.025;
            }
            else
            {
                return account.Balance * 0.007;
            }
        }
    }
}
