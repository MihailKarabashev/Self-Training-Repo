namespace DocumentTypes.CreatorModels;

public class CV : Document
{
    public override void CreatePages()
    {
        base.Pages.Add(new BioPage());
        base.Pages.Add(new SkillsPage());
    }
}
