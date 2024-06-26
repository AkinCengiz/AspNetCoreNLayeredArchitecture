﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreNLayeredArchitecture.Core.Services;
public interface IService<T> where T : class
{
	Task<T> GetByIdAsync(int id);
	Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter = null);
	IQueryable<T> Where(Expression<Func<T, bool>> filter);
	Task<bool> AnyAsync(Expression<Func<T, bool>> filter);
	Task<T> AddAsync(T entity);
	Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
	Task UpdateAsync(T entity);
	Task DeleteAsync(T entity);
	Task DeleteRangeAsync(IEnumerable<T> entities);
}
