using CasaVanilha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaVanilha.Infra.Data.EntitiesConfiguration;

public class SaleConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.QuantitySold)
            .IsRequired();

        builder.Property(s => s.SaleDateTime)
            .IsRequired();

        builder.HasOne(s => s.Product)
            .WithMany()
            .HasForeignKey(s => s.Id)
            .IsRequired();
    }
}
