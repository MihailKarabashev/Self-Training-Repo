using AutoMapper;
using CqrsMediatR.Dtos.Products;
using CqrsMediatR.Queries;
using MediatR;

namespace CqrsMediatR.Handlers;

public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<ProductResponseModel>>
{
    private readonly FakeDataStore fakeDataStore;
    private readonly IMapper mapper;

    public GetProductsHandler(
        FakeDataStore fakeDataStore,
        IMapper mapper)
    {
        this.fakeDataStore = fakeDataStore;
        this.mapper = mapper;
    }

    public async Task<IEnumerable<ProductResponseModel>> Handle
         (GetProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await fakeDataStore.GetAllProducts();
        var productDtos = mapper.Map<IEnumerable<ProductResponseModel>>(products);

        return productDtos;
    }
}
