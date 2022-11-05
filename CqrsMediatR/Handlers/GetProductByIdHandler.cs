using CqrsMediatR.Queries;
using MediatR;

namespace CqrsMediatR.Handlers;

public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
{
    private readonly FakeDataStore fakeDataStore;

    public GetProductByIdHandler(FakeDataStore fakeDataStore)
    {
        this.fakeDataStore = fakeDataStore;
    }

    public async Task<Product?> Handle(GetProductByIdQuery request,
        CancellationToken cancellationToken)
    {
        var product = await fakeDataStore.GetById(request.Id);

        return product;
    }
}
