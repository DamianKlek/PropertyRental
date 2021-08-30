using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Persistance.Configurations
{
	class OfferConfiguration : IEntityTypeConfiguration<Offer>
	{
		public void Configure(EntityTypeBuilder<Offer> builder)
		{
			builder.Property(p => p.DayCost).IsRequired();
		}
	}
}
