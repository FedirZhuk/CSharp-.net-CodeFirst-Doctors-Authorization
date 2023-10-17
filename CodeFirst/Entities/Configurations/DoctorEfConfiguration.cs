using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cwiczenia9.Entities.Configurations;

public class DoctorEfConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.HasKey(p => p.IdDoctor);
        builder.Property(e => e.IdDoctor).UseIdentityColumn();

        builder.ToTable("Doctor");
        
        builder.HasData(
            new Doctor { IdDoctor = 1, FirstName = "Ivan", LastName = "Illarionov", Email = "smith@example.com" },
            new Doctor { IdDoctor = 2, FirstName = "Krzysztof", LastName = "Kroczyński", Email = "johnson@example.com" }
        );
    }
}