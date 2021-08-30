using FluentValidation;

namespace PropertyRental.Application.Availabilities.Commands.UpdateAvailability
{
	public class UpdateAvailabilityCommandValidator : AbstractValidator<UpdateAvailabilityCommand>
	{
		public UpdateAvailabilityCommandValidator()
		{
			RuleFor(a => a.Day).NotNull();
			RuleFor(a => a.AvailabilityStatus).NotNull().GreaterThanOrEqualTo(0);
			RuleFor(a => a.OfferId).NotNull().GreaterThan(0);
		}
	}
}
