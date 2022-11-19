namespace DocumentTypes.CreatorModels;

public abstract class Document
{
    private List<Page> _pages = new List<Page>();

    public Document()
    {
        CreatePages();
    }

    public List<Page> Pages => _pages;

    public abstract void CreatePages();
}
