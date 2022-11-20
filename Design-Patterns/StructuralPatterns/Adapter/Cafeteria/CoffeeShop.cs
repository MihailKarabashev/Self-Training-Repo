namespace Cafeteria;

public class CoffeeShop
{
    private IDessertAdapter _dessertAdapter;

	public CoffeeShop()
	{
		_dessertAdapter = new DessertAdapter();
	}

	public void DisplayDesserts()
	{
		var desserts = _dessertAdapter.GetDesserts();

		foreach (var dessert in desserts)
		{
			Console.WriteLine($"{dessert.Name}  ${dessert.Price}");
		}
	}
}
