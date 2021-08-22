using FluentValidation;

namespace PropertyRental.Application.Properties.Commands.UpdateProperty
{
	public class UpdatePropertyCommandValidator : AbstractValidator<UpdatePropertyCommand>
	{
		public UpdatePropertyCommandValidator()
		{
			RuleFor(p => p.Name).NotEmpty().MaximumLength(50);
			RuleFor(p => p.Description).NotEmpty();
		}
	}
}
