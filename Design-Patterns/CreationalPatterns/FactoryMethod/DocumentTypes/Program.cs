using DocumentTypes.CreatorModels;

Document[] documents = new Document[2];

documents[0] = new CV();
documents[1] = new Report();

foreach (var document in documents)
{
    Console.WriteLine("\n" + document.GetType().Name + "--");
	foreach (var page in document.Pages)
	{
        Console.WriteLine(" " + page.GetType().Name);
    }
}