using Cafeteria.Models;

namespace Cafeteria;

public class DessertStorage
{
   private List<Dessert> _desserts;

	public DessertStorage()
	{
        _desserts = new List<Dessert>
        {
            new Dessert {Name = "Cake", Price = 14M, Quantity = 200},
            new Dessert {Name = "Donut", Price = 19.99M, Quantity = 20},
            new Dessert {Name = "I dont know", Price = 12M, Quantity = 44}
        };
    }

    public List<Dessert> GetDesserts()
    {
        return _desserts;
    }
}
