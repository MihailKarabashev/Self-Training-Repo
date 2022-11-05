using AutoMapper;
using CqrsMediatR.Commands;
using MediatR;

namespace CqrsMediatR.Handlers;

public class AddProductHandler : IRequestHandler<AddProductCommand>
{
    private readonly FakeDataStore fakeDataStore;
    private readonly IMapper mapper;

    public AddProductHandler(
        FakeDataStore fakeDataStore,
        IMapper mapper)
    {
        this.fakeDataStore = fakeDataStore;
        this.mapper = mapper;
    }

    //Unit represents a void type
    public async Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        var product = mapper.Map<Product>(request.product);

        await fakeDataStore.AddProduct(product);
        return Unit.Value;
    }
}
