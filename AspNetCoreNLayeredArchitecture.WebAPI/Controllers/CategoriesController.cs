using AspNetCoreNLayeredArchitecture.Core.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreNLayeredArchitecture.WebAPI.Controllers;

public class CategoriesController : CustomBaseController
{
	private readonly ICategoryService _categoryService;

	public CategoriesController(ICategoryService categoryService)
	{
		_categoryService = categoryService;
	}

	[HttpGet("[action]/{categoryId}")]
	public async Task<IActionResult> GetSingleCategoryByIdWithProducts(int categoryId)
	{
		return CreateActionResult(await _categoryService.GetSingleCategoryByIdWithProductsAsync(categoryId));
	}
}
