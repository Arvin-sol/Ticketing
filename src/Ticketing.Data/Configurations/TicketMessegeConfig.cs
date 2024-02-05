
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ticketing.Data.Entities.TicketingEntities;

namespace Ticketing.Data.Configurations;
public class TicketMessegeConfig : IEntityTypeConfiguration<TicketMessege>
{
    public void Configure(EntityTypeBuilder<TicketMessege> builder)
    {
        builder.Property(t => t.Message)
            .IsRequired()
            .HasMaxLength(500);
    }
}

