using Cafeteria.Models;

namespace Cafeteria;

public interface IDessertAdapter
{
    IList<DessertInfo> GetDesserts();
}
