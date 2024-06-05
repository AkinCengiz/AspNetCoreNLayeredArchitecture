
using System.Reflection;
using AspNetCoreNLayeredArchitecture.Core.Repositories;
using AspNetCoreNLayeredArchitecture.Core.Services;
using AspNetCoreNLayeredArchitecture.Core.UnitOfWorks;
using AspNetCoreNLayeredArchitecture.Repository;
using AspNetCoreNLayeredArchitecture.Repository.Repositories;
using AspNetCoreNLayeredArchitecture.Repository.UnitOfWorks;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreNLayeredArchitecture.WebAPI;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.

		builder.Services.AddControllers();
		// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
		builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
		builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
		//builder.Services.AddScoped(typeof(IService<>), typeof(GenericRepository<>));
		builder.Services.AddDbContext<AppDbContext>(options =>
		{
			options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), options =>
			{
				options.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
			});
		});
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen();

		var app = builder.Build();

		// Configure the HTTP request pipeline.
		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		}

		app.UseHttpsRedirection();

		app.UseAuthorization();


		app.MapControllers();

		app.Run();
	}
}
