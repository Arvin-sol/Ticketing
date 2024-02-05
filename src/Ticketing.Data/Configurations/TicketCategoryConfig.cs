

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ticketing.Data.Entities;

namespace Ticketing.Data.Configurations;
public class TicketCategoryConfig : IEntityTypeConfiguration<TicketCategory>
{
    public void Configure(EntityTypeBuilder<TicketCategory> builder)
    {
        builder.Property(p=>p.CategoryTitle)
            .IsRequired()
            .HasMaxLength(50);
    }
}

