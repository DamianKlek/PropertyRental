using FluentValidation;

namespace PropertyRental.Application.Offers.Commands.CreateOffer
{
	public class CreateOfferCommandValidator : AbstractValidator<CreateOfferCommand>
	{
		public CreateOfferCommandValidator()
		{
			RuleFor(o => o.DayCost).NotNull();
			RuleFor(o => o.PropertyId).NotNull().GreaterThan(0);
		}
	}
}
