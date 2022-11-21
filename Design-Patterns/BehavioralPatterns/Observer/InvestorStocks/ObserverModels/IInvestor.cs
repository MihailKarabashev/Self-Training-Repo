using InvestorStocks.SubjectModels;

namespace InvestorStocks.ObserverModels;

public interface IInvestor
{
   void Update(Stock stock);
}
