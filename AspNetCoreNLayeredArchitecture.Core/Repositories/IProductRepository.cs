﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreNLayeredArchitecture.Core.Models;

namespace AspNetCoreNLayeredArchitecture.Core.Repositories;
public interface IProductRepository : IGenericRepository<Product>
{
	Task<List<Product>> GetProductsWithCategory();
}
