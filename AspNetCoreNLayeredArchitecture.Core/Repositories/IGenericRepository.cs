﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreNLayeredArchitecture.Core.Repositories;
public interface IGenericRepository<T> where T : class
{
	IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null);
	Task<T> GetByIdAsync(int id);
	IQueryable<T> Where(Expression<Func<T, bool>> filter);
	Task<bool> AnyAsync(Expression<Func<T, bool>> filter);
	Task AddAsync(T entity);
	Task AddRangeAsync(IEnumerable<T> entities);
	void Update(T entity);
	void Delete(T entity);
	void DeleteRange(IEnumerable<T> entities);
	
}
