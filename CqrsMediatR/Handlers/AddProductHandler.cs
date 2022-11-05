using CqrsMediatR.Commands;
using MediatR;

namespace CqrsMediatR.Handlers;

public class AddProductHandler : IRequestHandler<AddProductCommand>
{
    private readonly FakeDataStore fakeDataStore;

    public AddProductHandler(FakeDataStore fakeDataStore)
    {
        this.fakeDataStore = fakeDataStore;
    }

    //Unit represents a void type
    public async Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        await fakeDataStore.AddProduct(request.product);
        return Unit.Value;
    }
}
