using BakeryShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BakeryShop.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //Fluent API

            builder.Property(p => p.ImageName)
                .HasMaxLength(50)
                .HasColumnName("ImageFileName")
                .IsRequired();
        }
    }
}
