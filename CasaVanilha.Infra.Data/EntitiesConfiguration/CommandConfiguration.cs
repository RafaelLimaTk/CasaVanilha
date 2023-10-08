using CasaVanilha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CasaVanilha.Infra.Data.EntitiesConfiguration;

public class CommandConfiguration : IEntityTypeConfiguration<Command>
{
    public void Configure(EntityTypeBuilder<Command> builder)
    {
        builder.HasKey(c => c.Id);

        builder.HasOne(c => c.Order)
            .WithOne()
            .HasForeignKey<Command>(c => c.Id)
            .IsRequired();
    }
}
