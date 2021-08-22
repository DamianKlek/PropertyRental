using FluentValidation;

namespace PropertyRental.Application.Tenants.Commands.UpdateTenant
{
	public class UpdateTenantCommandValidator : AbstractValidator<UpdateTenantCommand>
	{
		public UpdateTenantCommandValidator()
		{
			RuleFor(t => t.FirstName).NotEmpty().MaximumLength(50);
			RuleFor(t => t.LastName).NotEmpty().MaximumLength(50);
			RuleFor(t => t.Email).NotEmpty();
		}
	}
}
