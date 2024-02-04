

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ticketing.Data.Entities;

namespace Ticketing.Data.Configurations;
public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(u => u.Name)
                .HasMaxLength(50)
                  .IsRequired();

        builder.Property(u => u.LastName)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(u => u.Password)
            .IsRequired();


        builder.Property(u => u.Email)
            .IsRequired();
    }
}

