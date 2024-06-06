using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreNLayeredArchitecture.Core.Models;
using AspNetCoreNLayeredArchitecture.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreNLayeredArchitecture.Repository.Repositories;
public class CategoryRepository : GenericRepository<Category>,ICategoryRepository
{
	public CategoryRepository(AppDbContext context) : base(context)
	{
	}

	public async Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId)
	{
		//return await _context.Categories.Include(x => x.Products).SingleOrDefaultAsync(x => x.Id == categoryId);
		return await _context.Categories.Include(c => c.Products).Where(c => c.Id == categoryId).SingleOrDefaultAsync();
	}
}
