using CqrsMediatR.Dtos.Products;
using MediatR;

namespace CqrsMediatR.Queries;

public record GetProductByIdQuery(int Id) : IRequest<ProductResponseModel>;
