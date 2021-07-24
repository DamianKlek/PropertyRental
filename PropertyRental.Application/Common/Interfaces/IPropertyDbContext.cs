using Microsoft.EntityFrameworkCore;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Interfaces
{
	public interface IPropertyDbContext
	{
		DbSet<Availability> Availabilities { get; set; }
		DbSet<Contract> Contracts { get; set; }
		DbSet<Image> Images { get; set; }
		DbSet<Property> Properties { get; set; }
		DbSet<Address> Addresses { get; set; }
		DbSet<PropertyRent> PropertyRents { get; set; }
		DbSet<Tag> Tags { get; set; }
		DbSet<Tenant> Tenants { get; set; }

		Task<int> SaveChangesAsync(CancellationToken cancellationToken);
	}
}
