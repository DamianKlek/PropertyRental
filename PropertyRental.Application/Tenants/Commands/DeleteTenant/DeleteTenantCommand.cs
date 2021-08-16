using MediatR;

namespace PropertyRental.Application.Tenants.Commands.DeleteTenant
{
	public class DeleteTenantCommand : IRequest
	{
		public int TenantId { get; set; }
	}
}
