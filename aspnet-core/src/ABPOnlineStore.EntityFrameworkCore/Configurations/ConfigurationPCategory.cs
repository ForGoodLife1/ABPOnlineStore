using ABPOnlineStore.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ABPOnlineStore.Configurations
{
    internal class ConfigurationPCategory : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ConfigureByConvention();
            builder.Property(X=>X.Id).ValueGeneratedNever();
            builder.Property(X => X.NameAr).HasMaxLength(ABPOnlineStoreConsts.GenralTextMaxLength);
            builder.Property(X => X.NameEn).HasMaxLength(ABPOnlineStoreConsts.GenralTextMaxLength);
            builder.Property(X => X.DescriptionAr).HasMaxLength(ABPOnlineStoreConsts.GenralTextMaxLength);
            builder.Property(X => X.DescriptionEn).HasMaxLength(ABPOnlineStoreConsts.GenralTextMaxLength);
            builder.ToTable("Category");
        }
    }
}
