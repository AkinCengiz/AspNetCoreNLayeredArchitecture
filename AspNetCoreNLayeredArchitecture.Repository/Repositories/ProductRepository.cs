using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreNLayeredArchitecture.Core.Models;
using AspNetCoreNLayeredArchitecture.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreNLayeredArchitecture.Repository.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
	public async Task<List<Product>> GetProductsWithCategory()
	{
		//Eager loading
		return await _context.Products.Include(x => x.Category).ToListAsync();
	}

	public ProductRepository(AppDbContext context) : base(context)
	{

	}
}
