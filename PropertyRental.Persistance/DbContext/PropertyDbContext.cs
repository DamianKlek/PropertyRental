using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Common;
using PropertyRental.Domain.Entities;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Persistance
{
	public class PropertyDbContext : DbContext, IPropertyDbContext
	{
		private readonly IDateTime _dateTime;
		public PropertyDbContext(DbContextOptions<PropertyDbContext> options) : base(options)
		{
		}
		public PropertyDbContext(DbContextOptions<PropertyDbContext> options, IDateTime dateTime) : base(options)
		{
			_dateTime = dateTime;
		}

		public DbSet<Availability> Availabilities { get; set; }
		public DbSet<Contract> Contracts { get; set; }
		public DbSet<Image> Images { get; set; }
		public DbSet<Property> Properties { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<PropertyRent> PropertyRents { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<Tenant> Tenants { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

			modelBuilder.SeedData();
		}

		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
		{
			foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
			{
				switch (entry.State)
				{
					case EntityState.Added:
						entry.Entity.CreatedBy = string.Empty;
						entry.Entity.Created = _dateTime.Now;
						entry.Entity.StatusId = 1;
						break;
					case EntityState.Modified:
						entry.Entity.ModifiedBy = string.Empty;
						entry.Entity.Modified = _dateTime.Now;
						entry.Entity.StatusId += 1;
						break;
					case EntityState.Deleted:
						entry.Entity.ModifiedBy = string.Empty;
						entry.Entity.Modified = _dateTime.Now;
						entry.Entity.InactivatedBy = string.Empty;
						entry.Entity.Inactivated = _dateTime.Now;
						entry.Entity.StatusId = 0;
						entry.State = EntityState.Modified;
						break;
				}
			}

			return base.SaveChangesAsync(cancellationToken);
		}
	}
}
