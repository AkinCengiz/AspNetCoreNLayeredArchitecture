using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCoreNLayeredArchitecture.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetCoreNLayeredArchitecture.Repository.Configurations;
public class ProductFeatureConfiguration : IEntityTypeConfiguration<ProductFeature>
{
	public void Configure(EntityTypeBuilder<ProductFeature> builder)
	{
		builder.HasKey(x => x.Id);
		builder.Property(x => x.Id).UseIdentityColumn();
		builder.Property(x => x.Color).HasMaxLength(30).IsRequired();
		builder.Property(x => x.Height).HasMaxLength(50).IsRequired();
		builder.Property(x => x.Width).HasMaxLength(50).IsRequired();
		builder.Property(x => x.ProductId).IsRequired();
		builder.HasOne(x => x.Product).WithOne(x => x.ProductFeature).HasForeignKey<ProductFeature>(x => x.ProductId);
		builder.ToTable("ProductFeatures");
	}
}
