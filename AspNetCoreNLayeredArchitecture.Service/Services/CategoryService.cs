using AspNetCoreNLayeredArchitecture.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreNLayeredArchitecture.Core.DTOs;
using AspNetCoreNLayeredArchitecture.Core.Repositories;
using AspNetCoreNLayeredArchitecture.Core.Services;
using AspNetCoreNLayeredArchitecture.Core.UnitOfWorks;
using AutoMapper;

namespace AspNetCoreNLayeredArchitecture.Service.Services;
public class CategoryService : Service<Category>, ICategoryService
{
	private readonly ICategoryRepository _categoryRepository;
	private readonly IMapper _mapper;
	public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, ICategoryRepository categoryRepository, IMapper mapper) : base(repository, unitOfWork)
	{
		_categoryRepository = categoryRepository;
		_mapper = mapper;
	}

	public async Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId)
	{
		var category = await _categoryRepository.GetSingleCategoryByIdWithProductsAsync(categoryId);
		var categoryWithProducts = _mapper.Map<CategoryWithProductsDto>(category);
		return CustomResponseDto<CategoryWithProductsDto>.Success(200, categoryWithProducts);
	}
}
