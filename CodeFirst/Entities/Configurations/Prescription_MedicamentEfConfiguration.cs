using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cwiczenia9.Entities.Configurations;

public class Prescription_MedicamentEfConfiguration : IEntityTypeConfiguration<Prescription_Medicament>
{
    public void Configure(EntityTypeBuilder<Prescription_Medicament> builder)
    {
        builder.HasKey(pm => new { pm.PrescriptionId, pm.MedicamentId });
        builder.ToTable("Prescription_Medicament");

        builder.HasOne(pm => pm.Prescription)
            .WithMany(p => p.PrescriptionMedicaments)
            .HasForeignKey(pm => pm.PrescriptionId);

        builder
            .HasOne(pm => pm.Medicament)
            .WithMany(m => m.PrescriptionMedicaments)
            .HasForeignKey(pm => pm.MedicamentId);
        
        builder.HasData(
            new Prescription_Medicament { PrescriptionId = 1, MedicamentId = 1, Dose = 2, Details = "Take twice a day" },
            new Prescription_Medicament { PrescriptionId = 1, MedicamentId = 2, Dose = 1, Details = "Take once daily" },
            new Prescription_Medicament { PrescriptionId = 2, MedicamentId = 1, Dose = 3, Details = "Take three times a day" }
        );
    }
}