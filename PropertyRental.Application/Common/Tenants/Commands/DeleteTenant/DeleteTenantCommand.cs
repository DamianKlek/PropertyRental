using MediatR;

namespace PropertyRental.Application.Common.Tenants.Commands.DeleteTenant
{
	public class DeleteTenantCommand : IRequest
	{
		public int TenantId { get; set; }
	}
}
