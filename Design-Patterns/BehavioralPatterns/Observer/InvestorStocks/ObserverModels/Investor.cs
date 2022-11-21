using InvestorStocks.SubjectModels;

namespace InvestorStocks.ObserverModels;

public class Investor : IInvestor
{
    public Investor(string username)
    {
        Username = username;
    }
    public string Username { get; init; }

    public void Update(Stock stock)
    {
        Console.WriteLine($"{Username} has {stock.Symbol} with price equals to ${stock.Price}");
    }
}
