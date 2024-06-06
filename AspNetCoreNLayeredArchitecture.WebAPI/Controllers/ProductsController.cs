using AspNetCoreNLayeredArchitecture.Core.DTOs;
using AspNetCoreNLayeredArchitecture.Core.Models;
using AspNetCoreNLayeredArchitecture.Core.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreNLayeredArchitecture.WebAPI.Controllers;
public class ProductsController : CustomBaseController
{
	private readonly IMapper _mapper;
	private readonly IService<Product> _service;
	private readonly IProductService _productService;

	public ProductsController(IMapper mapper, IService<Product> service, IProductService productService)
	{
		_mapper = mapper;
		_service = service;
		_productService = productService;
	}

	[HttpGet("GetProductWithCategory")]
	public async Task<IActionResult> GetProductWithCategory()
	{
		return CreateActionResult(await _productService.GetProductsWithCategory());
	}

	[HttpGet]
	public async Task<IActionResult> GetAll()
	{
		var products = await _service.GetAll();
		var productsDto = _mapper.Map<List<ProductDto>>(products.ToList());
		return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productsDto));
	}

	[HttpGet("{id}")]
	public async Task<IActionResult> GetById(int id)
	{
		var product = await _service.GetByIdAsync(id);
		var productDto = _mapper.Map<ProductDto>(product);
		return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productDto));
	}

	[HttpPost]
	public async Task<IActionResult> Add(ProductDto productDto)
	{
		var product = await _service.AddAsync(_mapper.Map<Product>(productDto));
		var pDto = _mapper.Map<ProductDto>(product);

		return CreateActionResult(CustomResponseDto<ProductDto>.Success(201, pDto));
	}

	[HttpPut]
	public async Task<IActionResult> Update(ProductUpdateDto productDto)
	{
		await _service.UpdateAsync(_mapper.Map<Product>(productDto));
		return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
	}

	[HttpDelete("{id}")]
	public async Task<IActionResult> Remove(int id)
	{
		var product = await _service.GetByIdAsync(id);
		await _service.DeleteAsync(product);
		return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
	}
}
