using CqrsMediatR.Queries;
using MediatR;

namespace CqrsMediatR.Handlers;

public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
{
    private readonly FakeDataStore fakeDataStore;

    public GetProductsHandler(FakeDataStore fakeDataStore)
    {
        this.fakeDataStore = fakeDataStore;
    }

    public async Task<IEnumerable<Product>> Handle
         (GetProductsQuery request, CancellationToken cancellationToken)
    {
        return await fakeDataStore.GetAllProducts();
    }
}
