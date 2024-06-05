using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreNLayeredArchitecture.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetCoreNLayeredArchitecture.Repository.Seeds;

public class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
{
	public void Configure(EntityTypeBuilder<ProductFeature> builder)
	{
		builder.HasData(
			new ProductFeature { Id = 1, Color = "Kırmızı", Height = 100, Width = 50, ProductId = 1, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 2, Color = "Mavi", Height = 150, Width = 60, ProductId = 2, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 3, Color = "Yeşil", Height = 200, Width = 70, ProductId = 3, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 4, Color = "Siyah", Height = 250, Width = 80, ProductId = 4, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 5, Color = "Beyaz", Height = 300, Width = 90, ProductId = 5, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 6, Color = "Sarı", Height = 350, Width = 100, ProductId = 6, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 7, Color = "Pembe", Height = 400, Width = 110, ProductId = 7, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 8, Color = "Mor", Height = 450, Width = 120, ProductId = 8, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 9, Color = "Turuncu", Height = 500, Width = 130, ProductId = 9, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 10, Color = "Gri", Height = 550, Width = 140, ProductId = 10, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 11, Color = "Kahverengi", Height = 600, Width = 150, ProductId = 11, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 12, Color = "Lacivert", Height = 650, Width = 160, ProductId = 12, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 13, Color = "Bordo", Height = 700, Width = 170, ProductId = 13, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 14, Color = "Pembe", Height = 750, Width = 180, ProductId = 14, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 15, Color = "Siyah", Height = 800, Width = 190, ProductId = 15, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 16, Color = "Beyaz", Height = 850, Width = 200, ProductId = 16, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 17, Color = "Sarı", Height = 900, Width = 210, ProductId = 17, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 18, Color = "Pembe", Height = 950, Width = 220, ProductId = 18, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 19, Color = "Mor", Height = 1000, Width = 230, ProductId = 19, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 20, Color = "Turuncu", Height = 1050, Width = 240, ProductId = 20, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 21, Color = "Gri", Height = 1100, Width = 250, ProductId = 21, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 22, Color = "Kahverengi", Height = 1150, Width = 260, ProductId = 22, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 23, Color = "Lacivert", Height = 1200, Width = 270, ProductId = 23, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 24, Color = "Bordo", Height = 1250, Width = 280, ProductId = 24, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 25, Color = "Pembe", Height = 1300, Width = 290, ProductId = 25, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new ProductFeature { Id = 26, Color = "Siyah", Height = 1350, Width = 300, ProductId = 26, IsActive = true, IsDeleted = false, CreateAt = DateTime.Now }
		);
	}
}
