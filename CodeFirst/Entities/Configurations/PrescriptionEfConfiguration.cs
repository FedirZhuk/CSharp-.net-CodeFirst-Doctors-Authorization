using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cwiczenia9.Entities.Configurations;

public class PrescriptionEfConfiguration : IEntityTypeConfiguration<Prescription>
{
    public void Configure(EntityTypeBuilder<Prescription> builder)
    {
        builder.HasKey(p => p.IdPrescription);
        builder.Property(p => p.IdPrescription).UseIdentityColumn();
        builder.ToTable("Prescription");


        builder
            .HasOne(pm => pm.Doctor)
            .WithMany(m => m.Prescriptions)
            .HasForeignKey(pm => pm.DoctorId);

        builder
            .HasOne(pm => pm.Patient)
            .WithMany(m => m.Prescriptions)
            .HasForeignKey(pm => pm.PatientId);
        
        builder.HasData(
            new Prescription { IdPrescription = 1, Date = DateTime.Now, DueDate = DateTime.Now.AddDays(7), PatientId = 1, DoctorId = 1 },
            new Prescription { IdPrescription = 2, Date = DateTime.Now, DueDate = DateTime.Now.AddDays(7), PatientId = 2, DoctorId = 2 }
        );
    }
}