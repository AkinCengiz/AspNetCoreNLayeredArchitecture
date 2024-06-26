﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreNLayeredArchitecture.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreNLayeredArchitecture.Repository.Repositories;
public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
	protected readonly AppDbContext _context;
	private readonly DbSet<TEntity> _dbSet;

	public GenericRepository(AppDbContext context)
	{
		_context = context;
		_dbSet = _context.Set<TEntity>();
	}

	public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
	{
		return _dbSet.AsNoTracking().AsQueryable();
	}

	public async Task<TEntity> GetByIdAsync(int id)
	{
		return await _dbSet.FindAsync(id);
	}

	public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> filter)
	{
		return _dbSet.Where(filter).AsNoTracking().AsQueryable();
	}

	public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter)
	{
		return await _dbSet.AnyAsync(filter);
	}

	public async Task AddAsync(TEntity entity)
	{
		await _dbSet.AddAsync(entity);
	}

	public async Task AddRangeAsync(IEnumerable<TEntity> entities)
	{
		await _dbSet.AddRangeAsync(entities);
	}

	public void Update(TEntity entity)
	{
		_dbSet.Update(entity);
	}

	public void Delete(TEntity entity)
	{
		_dbSet.Remove(entity);
	}

	public void DeleteRange(IEnumerable<TEntity> entities)
	{
		_dbSet.RemoveRange(entities);
	}
}
