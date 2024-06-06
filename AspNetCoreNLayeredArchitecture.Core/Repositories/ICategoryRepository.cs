using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreNLayeredArchitecture.Core.Models;

namespace AspNetCoreNLayeredArchitecture.Core.Repositories;
public interface ICategoryRepository : IGenericRepository<Category>
{
	Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId);
}
