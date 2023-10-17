using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cwiczenia9.Entities.Configurations;

public class UserEfConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.IdUser);
        builder.Property(u => u.IdUser).UseIdentityColumn();

        builder.ToTable("User");
        
        builder.HasData(
            new User { IdUser = 1, Login = "Ivan", Password = "Illarionov"}
        );
    }
}