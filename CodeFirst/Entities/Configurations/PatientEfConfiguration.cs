using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cwiczenia9.Entities.Configurations;

public class PatientEfConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.HasKey(p => p.IdPatient);
        builder.Property(p => p.IdPatient).UseIdentityColumn();
        builder.ToTable("Patient");

        
        builder.HasData(
            new Patient { IdPatient = 1, FirstName = "John", LastName = "Doe", Birthdate = DateTime.Parse("1990-01-01") },
            new Patient { IdPatient = 2, FirstName = "Jane", LastName = "Smith", Birthdate = DateTime.Parse("1995-05-10") }
        );
    }
}