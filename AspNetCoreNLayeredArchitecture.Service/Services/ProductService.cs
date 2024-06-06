using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreNLayeredArchitecture.Core.DTOs;
using AspNetCoreNLayeredArchitecture.Core.Models;
using AspNetCoreNLayeredArchitecture.Core.Repositories;
using AspNetCoreNLayeredArchitecture.Core.Services;
using AspNetCoreNLayeredArchitecture.Core.UnitOfWorks;
using AutoMapper;

namespace AspNetCoreNLayeredArchitecture.Service.Services;
public class ProductService : Service<Product>, IProductService
{
	private readonly IProductRepository _productRepository;
	private readonly IMapper _mapper;

	public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
	{
		_productRepository = productRepository;
		_mapper = mapper;
	}

	public async Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory()
	{
		var product = await _productRepository.GetProductsWithCategory();
		var productDto = _mapper.Map<List<ProductWithCategoryDto>>(product);
		return CustomResponseDto<List<ProductWithCategoryDto>>.Success(200, productDto);
	}
}
