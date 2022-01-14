using ImpostosStrategyPattern;

namespace InvestmentMaker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var account = new Account(1000);

            var i1 = new AgressiveInvestment();
            var i2 = new ModerateInvestment();
            var i3 = new ConservativeInvestment();

            var investor = new Investor();

            investor.Invest(account, i1);
            investor.Invest(account, i2);
            investor.Invest(account, i3);
        }
    }
}
