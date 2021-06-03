using Microsoft.EntityFrameworkCore;
using PropertyRental.Domain.Common;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Persistance
{
  public class PropertyDbContext : DbContext
  {
    public PropertyDbContext(DbContextOptions<PropertyDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
      foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
      {
        switch (entry.State)
        {
          case EntityState.Added:
            entry.Entity.CreatedBy = string.Empty;
            entry.Entity.Created = DateTime.Now;
            entry.Entity.StatusId = 1;
            break;
          case EntityState.Modified:
            entry.Entity.ModifiedBy = string.Empty;
            entry.Entity.Modified = DateTime.Now;
            entry.Entity.StatusId += 1;
            break;
          case EntityState.Deleted:
            entry.Entity.ModifiedBy = string.Empty;
            entry.Entity.Modified = DateTime.Now;
            entry.Entity.InactivatedBy = string.Empty;
            entry.Entity.Inactivated = DateTime.Now;
            entry.Entity.StatusId = 0;
            entry.State = EntityState.Modified;
            break;
        }
      }

      return base.SaveChangesAsync(cancellationToken);
    }
  }
}
