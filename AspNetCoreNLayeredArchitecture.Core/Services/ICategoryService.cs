using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreNLayeredArchitecture.Core.DTOs;
using AspNetCoreNLayeredArchitecture.Core.Models;

namespace AspNetCoreNLayeredArchitecture.Core.Services;
public interface ICategoryService : IService<Category>
{
	Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId);
}
