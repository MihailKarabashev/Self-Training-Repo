using CqrsMediatR.Dtos.Products;
using MediatR;

namespace CqrsMediatR.Queries;

//IRequst is requring collection of product. We specify what is the return type here.
public record GetProductsQuery : IRequest<IEnumerable<ProductResponseModel>>;

