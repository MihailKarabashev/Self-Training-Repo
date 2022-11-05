using AutoMapper;
using CqrsMediatR.Dtos.Products;

namespace CqrsMediatR.Profiles;

public class ProductsProfile : Profile
{
	public ProductsProfile()
	{
		CreateMap<ProductInputModel, Product>().ReverseMap();
	}
}
