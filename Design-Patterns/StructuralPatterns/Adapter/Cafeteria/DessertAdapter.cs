using Cafeteria.Models;

namespace Cafeteria;

public class DessertAdapter : IDessertAdapter
{
    private DessertStorage _dessertStorage;

    public DessertAdapter()
    {
        _dessertStorage = new DessertStorage();
    }

    public IList<DessertInfo> GetDesserts()
    {
        var desserts = _dessertStorage.GetDesserts();
        var dessertsInfoList = new List<DessertInfo>();

        foreach (var dessert in desserts)
        {
            dessertsInfoList.Add(new DessertInfo { Name = dessert.Name, Price = dessert.Price });
        }

        return dessertsInfoList;
    }
}
