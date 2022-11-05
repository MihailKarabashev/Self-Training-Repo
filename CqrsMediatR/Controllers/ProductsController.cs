using CqrsMediatR.Queries;
using CqrsMediatR.Queries.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsMediatR.Controllers;

[Route("api/products")]
[ApiController]
public class ProductsController : ControllerBase
{
	private readonly ISender sender;

	public ProductsController(ISender sender)
	{
		this.sender = sender;
	}

	[HttpGet]
	public async Task<IActionResult> GetProducts()
	{
		var products = await sender.Send(new GetProductsQuery());

		return Ok(products);
	}

	[HttpPost]
	public async Task<IActionResult> AddProduct([FromBody] Product product)
	{
		await sender.Send(new AddProductCommand(product));

		return StatusCode(201);
	}

}
