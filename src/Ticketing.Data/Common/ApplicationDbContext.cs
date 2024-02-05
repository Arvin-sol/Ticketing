using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Ticketing.Data.Entities;

namespace Ticketing.Data.Common;
public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
    : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("base");
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<User> users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserSelectedRols> UserSelectedRols { get; set;}
    public DbSet<TicketCategory> TicketCategories { get; set; }
    public DbSet<TicketMessege> TicketMesseges { get; set; }

}

