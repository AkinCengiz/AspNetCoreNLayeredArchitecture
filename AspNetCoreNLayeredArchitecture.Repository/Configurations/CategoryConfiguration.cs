using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreNLayeredArchitecture.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetCoreNLayeredArchitecture.Repository.Configurations;
public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
	public void Configure(EntityTypeBuilder<Category> builder)
	{
		builder.HasKey(x => x.Id);
		builder.Property(x => x.Id).UseIdentityColumn();
		builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
		builder.ToTable("Categories");
	}
}
