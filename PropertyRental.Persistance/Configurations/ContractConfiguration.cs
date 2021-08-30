using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Persistance.Configurations
{
	class ContractConfiguration : IEntityTypeConfiguration<Contract>
	{
		public void Configure(EntityTypeBuilder<Contract> builder)
		{
			builder.Property(p => p.StartRentDate).IsRequired();
			builder.Property(p => p.EndRentDate).IsRequired();
			builder.Property(p => p.RentCost).IsRequired();
		}
	}
}
