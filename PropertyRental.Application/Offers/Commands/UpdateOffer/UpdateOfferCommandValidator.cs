using FluentValidation;

namespace PropertyRental.Application.Offers.Commands.UpdateOffer
{
	public class UpdateOfferCommandValidator : AbstractValidator<UpdateOfferCommand>
	{
		public UpdateOfferCommandValidator()
		{
			RuleFor(o => o.DayCost).NotNull();
			RuleFor(o => o.PropertyId).NotNull().GreaterThan(0);
		}
	}
}
