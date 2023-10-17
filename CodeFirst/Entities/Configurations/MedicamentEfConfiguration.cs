using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cwiczenia9.Entities.Configurations;

public class MedicamentEfConfiguration : IEntityTypeConfiguration<Medicament>
{
    public void Configure(EntityTypeBuilder<Medicament> builder)
    {
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Id).UseIdentityColumn();
        builder.ToTable("Medicament");

        
        builder.HasData(
            new Medicament { Id = 1, Name = "Medicament 1", Description = "blabbla", Type = "antybiotyk" },
            new Medicament { Id = 2, Name = "Medicament 2", Description = "alalala", Type = "lek" }
        );
    }
}