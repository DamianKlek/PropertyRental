using FluentValidation;

namespace PropertyRental.Application.Availabilities.Commands.CreateAvailability
{
	public class CreateAvailabilityCommandValidator : AbstractValidator<CreateAvailabilityCommand>
	{
		public CreateAvailabilityCommandValidator()
		{
			RuleFor(a => a.Day).NotNull();
			RuleFor(a => a.AvailabilityStatus).NotNull().GreaterThanOrEqualTo(0);
			RuleFor(a => a.OfferId).NotNull().GreaterThan(0);
		}
	}
}
