using ABPOnlineStore.Categories;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABPOnlineStore.Products;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ABPOnlineStore.Configurations
{
    internal class ConfigurationProduct : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
                   
          builder.ConfigureByConvention();
          builder.Property(X => X.NameAr).HasMaxLength(ABPOnlineStoreConsts.GenralTextMaxLength);
          builder.Property(X => X.NameEn).HasMaxLength(ABPOnlineStoreConsts.GenralTextMaxLength);
          builder.Property(X => X.DescriptionAr).HasMaxLength(ABPOnlineStoreConsts.GenralTextMaxLength);
          builder.Property(X => X.DescriptionEn).HasMaxLength(ABPOnlineStoreConsts.GenralTextMaxLength);
            builder.HasOne(X => X.Catogry)
                  .WithMany()
                  .HasForeignKey(X => X.CategoryId)
                  .IsRequired();
            builder.ToTable("Products");
        }
    }
}
