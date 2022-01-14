namespace InvestmentMaker
{
    public class Investor
    {
        public void Invest(Account account, IInvestment investment)
        {
            var result = investment.Invest(account);
            Console.WriteLine(result);
        }
    }
}
