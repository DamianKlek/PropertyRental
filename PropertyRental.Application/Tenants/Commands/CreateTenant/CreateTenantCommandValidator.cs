using FluentValidation;

namespace PropertyRental.Application.Tenants.Commands.CreateTenant
{
	public class CreateTenantCommandValidator : AbstractValidator<CreateTenantCommand>
	{
		public CreateTenantCommandValidator()
		{
			RuleFor(t => t.FirstName).NotEmpty().MaximumLength(50);
			RuleFor(t => t.LastName).NotEmpty().MaximumLength(50);
			RuleFor(t => t.Email).NotEmpty();
		}
	}
}
