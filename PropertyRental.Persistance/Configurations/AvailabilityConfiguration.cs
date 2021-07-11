using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Persistance.Configurations
{
	class AvailabilityConfiguration : IEntityTypeConfiguration<Availability>
	{
		public void Configure(EntityTypeBuilder<Availability> builder)
		{
			builder.Property(p => p.Day).IsRequired();
			builder.Property(p => p.AvailabilityStatus).IsRequired();
		}
	}
}
