using CqrsMediatR.Dtos.Products;
using MediatR;

namespace CqrsMediatR.Commands;

//IRequest has no returning value because we are not returning anything. We are just creating a product
public record AddProductCommand(ProductInputModel product) : IRequest;

