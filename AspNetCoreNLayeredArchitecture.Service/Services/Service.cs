using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreNLayeredArchitecture.Core.Repositories;
using AspNetCoreNLayeredArchitecture.Core.Services;
using AspNetCoreNLayeredArchitecture.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreNLayeredArchitecture.Service.Services;
public class Service<T> : IService<T> where T : class
{
	private readonly IGenericRepository<T> _repository;
	private readonly IUnitOfWork _unitOfWork;

	public Service(IGenericRepository<T> repository, IUnitOfWork unitOfWork)
	{
		_repository = repository;
		_unitOfWork = unitOfWork;
	}

	public async Task<T> GetByIdAsync(int id)
	{
		return await _repository.GetByIdAsync(id);
	}

	public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter = null)
	{
		return await _repository.GetAll(filter).ToListAsync();
	}

	public IQueryable<T> Where(Expression<Func<T, bool>> filter)
	{
		return _repository.Where(filter);
	}

	public async Task<bool> AnyAsync(Expression<Func<T, bool>> filter)
	{
		return await _repository.AnyAsync(filter);
	}

	public async Task<T> AddAsync(T entity)
	{
		await _repository.AddAsync(entity);
		await _unitOfWork.CommitAsync();
		return entity;
	}

	public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
	{
		await _repository.AddRangeAsync(entities);
		await _unitOfWork.CommitAsync();
		return entities;
	}

	public async Task UpdateAsync(T entity)
	{
		_repository.Update(entity);
		await _unitOfWork.CommitAsync();
	}

	public async Task DeleteAsync(T entity)
	{
		_repository.Delete(entity);
		await _unitOfWork.CommitAsync();
	}

	public async Task DeleteRangeAsync(IEnumerable<T> entities)
	{
		_repository.DeleteRange(entities);
		await _unitOfWork.CommitAsync();
	}
}
