namespace CqrsMediatR;

public class FakeDataStore
{
    private static List<Product> products;

    public FakeDataStore()
    {
        products = new List<Product>()
        {
            new Product {Id = 1, Name = "Test Product 1"},
            new Product {Id = 2, Name = "Test Product 2"},
            new Product {Id = 3, Name = "Test Product 3"},
        };
    }


    public async Task AddProduct(Product product)
    {
        products.Add(product);
        await Task.CompletedTask;
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        return await Task.FromResult(products);
    }
}
