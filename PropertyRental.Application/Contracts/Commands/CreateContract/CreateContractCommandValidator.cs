using FluentValidation;

namespace PropertyRental.Application.Contracts.Commands.CreateContract
{
	public class CreateContractCommandValidator : AbstractValidator<CreateContractCommand>
	{
		public CreateContractCommandValidator()
		{
			RuleFor(c => c.StartRentDate).NotNull();
			RuleFor(c => c.EndRentDate).NotNull();
			RuleFor(c => c.RentCost).NotNull().GreaterThan(0);
			RuleFor(c => c.TenantId).NotNull().GreaterThan(0);
			RuleFor(c => c.OfferId).NotNull().GreaterThan(0);
		}
	}
}
