using InvestorStocks.ObserverModels;
using InvestorStocks.SubjectModels;

Stock ibm = new IBM(120, "IBM S.Y.S");
IInvestor investor1 = new Investor("Misho");
IInvestor investor2 = new Investor("Koce");

ibm.Attach(investor1);
ibm.Attach(investor2);

ibm.Price = 140;

ibm.Detach(investor1);
ibm.Price = 99.99M;