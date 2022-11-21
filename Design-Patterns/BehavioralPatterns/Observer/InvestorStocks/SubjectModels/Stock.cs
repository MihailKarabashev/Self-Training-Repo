using InvestorStocks.ObserverModels;

namespace InvestorStocks.SubjectModels;

public abstract class Stock
{
	private readonly IList<IInvestor> _investors;
	private decimal _price;

	public Stock(decimal price, string symbol)
	{
		Symbol = symbol;
		_price = price;
		_investors = new List<IInvestor>();
	}
    public string Symbol { get; set; }

    public decimal Price 
	{
		get => _price;
		set
		{
			if (Math.Abs(_price - value) > 0.001M)
			{
				_price = value;
				Notify();
			}
		}
	}

	public void Attach(IInvestor investor) => _investors.Add(investor);

	public void Detach(IInvestor investor) => _investors.Remove(investor);

	private void Notify()
	{
		foreach (var investor in _investors)
		{
			investor.Update(this);
		}
	}
}
