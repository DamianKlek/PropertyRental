using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Persistance.Configurations
{
	public class TenantConfiguration : IEntityTypeConfiguration<Tenant>
	{
		public void Configure(EntityTypeBuilder<Tenant> builder)
		{
			builder.OwnsOne(p => p.Name).Property(p => p.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsRequired();
			builder.OwnsOne(p => p.Name).Property(p => p.LastName).HasColumnName("LastName").HasMaxLength(50).IsRequired();
			builder.OwnsOne(p => p.Email).Property(p => p.UserName).HasColumnName("EmailUserName").IsRequired();
			builder.OwnsOne(p => p.Email).Property(p => p.DomainName).HasColumnName("EmailDomainName").IsRequired();
		}
	}
}
