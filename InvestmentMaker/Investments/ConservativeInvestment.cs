using InvestmentMaker;

namespace ImpostosStrategyPattern
{
    public class ConservativeInvestment : IInvestment
    {
        public double Invest(Account account)
        {
            return account.Balance * 0.008;
        }
    }
}
