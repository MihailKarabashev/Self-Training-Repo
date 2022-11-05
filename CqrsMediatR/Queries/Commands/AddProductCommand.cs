using MediatR;

namespace CqrsMediatR.Queries.Commands;

public record AddProductCommand(Product product) : IRequest;
 
