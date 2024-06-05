using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreNLayeredArchitecture.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetCoreNLayeredArchitecture.Repository.Seeds;
public class CategorySeed : IEntityTypeConfiguration<Category>
{
	public void Configure(EntityTypeBuilder<Category> builder)
	{
		builder.HasData(
			new Category { Id = 1, Name = "Kalemler", IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new Category { Id = 2, Name = "Defterler", IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new() { Id = 3, Name = "Kitaplar", IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new() { Id = 4, Name = "Çantalar", IsActive = true, IsDeleted = false, CreateAt = DateTime.Now },
			new() { Id = 5, Name = "Kırtasiye", IsActive = true, IsDeleted = false, CreateAt = DateTime.Now }
			);
	}
}
