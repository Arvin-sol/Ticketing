

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ticketing.Data.Entities;
namespace Ticketing.Data.Configurations;
public class RoleConfig : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.Property(u=>u.UniqRoleTitle)
            .HasMaxLength(50)
            .IsRequired();
    }
}

