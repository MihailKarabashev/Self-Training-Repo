namespace DocumentTypes.CreatorModels;

public class Report : Document
{
    public override void CreatePages()
    {
        base.Pages.Add(new SummaryPage());
        base.Pages.Add(new ResultsPage());
    }
}
