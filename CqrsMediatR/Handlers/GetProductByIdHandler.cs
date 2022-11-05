using AutoMapper;
using CqrsMediatR.Dtos.Products;
using CqrsMediatR.Queries;
using MediatR;

namespace CqrsMediatR.Handlers;

public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, ProductResponseModel>
{
    private readonly FakeDataStore fakeDataStore;
    private readonly IMapper mapper;

    public GetProductByIdHandler(
        FakeDataStore fakeDataStore,
        IMapper mapper)
    {
        this.fakeDataStore = fakeDataStore;
        this.mapper = mapper;
    }

    public async Task<ProductResponseModel> Handle(GetProductByIdQuery request,
        CancellationToken cancellationToken)
    {
        var product = await fakeDataStore.GetById(request.Id);

        var productDto = mapper.Map<ProductResponseModel>(product);

        return productDto;
    }
}
