using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreNLayeredArchitecture.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetCoreNLayeredArchitecture.Repository.Seeds;
public class ProductSeed : IEntityTypeConfiguration<Product>
{
	public void Configure(EntityTypeBuilder<Product> builder)
	{
		builder.HasData(
			new Product { Id = 1, Name = "Pilot Kalem", Price = 12.50m, Stock = 100, CategoryId = 1, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 2, Name = "Kurşun Kalem", Price = 5.50m, Stock = 200, CategoryId = 1, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 3, Name = "Tükenmez Kalem", Price = 15.50m, Stock = 300, CategoryId = 1, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 4, Name = "Kareli Defter", Price = 7.50m, Stock = 400, CategoryId = 2, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 5, Name = "Çizgili Defter", Price = 7.50m, Stock = 300, CategoryId = 2, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 6, Name = "A5 Defter", Price = 12.50m, Stock = 150, CategoryId = 2, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 7, Name = "A4 Defter", Price = 15.50m, Stock = 250, CategoryId = 2, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 8, Name = "Düz Yazı Defter", Price = 10.50m, Stock = 350, CategoryId = 2, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 9, Name = "Harita Metot Defter", Price = 10.50m, Stock = 350, CategoryId = 2, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 10, Name = "Matematik 1", Price = 10.50m, Stock = 350, CategoryId = 3, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 11, Name = "Matematik 2", Price = 10.50m, Stock = 350, CategoryId = 3, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 12, Name = "Matematik 3", Price = 10.50m, Stock = 350, CategoryId = 3, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 13, Name = "Fizik 1", Price = 10.50m, Stock = 350, CategoryId = 3, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 14, Name = "Fizik 2", Price = 10.50m, Stock = 350, CategoryId = 3, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 15, Name = "Fizik 3", Price = 10.50m, Stock = 350, CategoryId = 3, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 16, Name = "Kimya 1", Price = 10.50m, Stock = 350, CategoryId = 3, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 17, Name = "Kimya 2", Price = 10.50m, Stock = 350, CategoryId = 3, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 18, Name = "Kimya 3", Price = 10.50m, Stock = 350, CategoryId = 3, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 19, Name = "Sırt Çantası", Price = 10.50m, Stock = 350, CategoryId = 4, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 20, Name = "Bilgisayar Çantası", Price = 10.50m, Stock = 350, CategoryId = 4, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 21, Name = "Spor Çantası", Price = 10.50m, Stock = 350, CategoryId = 4, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 22, Name = "Beslenme Çantası", Price = 10.50m, Stock = 350, CategoryId = 4, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 23, Name = "Kalem Kutusu", Price = 10.50m, Stock = 350, CategoryId = 5, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 24, Name = "Silgi", Price = 10.50m, Stock = 350, CategoryId = 5, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 25, Name = "Kalemtraş", Price = 10.50m, Stock = 350, CategoryId = 5, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Product { Id = 26, Name = "Kurşun", Price = 10.50m, Stock = 350, CategoryId = 5, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now }

		);
	}
}
