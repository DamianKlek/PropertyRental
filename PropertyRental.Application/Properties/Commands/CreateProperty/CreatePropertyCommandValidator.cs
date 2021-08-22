using FluentValidation;

namespace PropertyRental.Application.Properties.Commands.CreateProperty
{
	public class CreatePropertyCommandValidator : AbstractValidator<CreatePropertyCommand>
	{
		public CreatePropertyCommandValidator()
		{
			RuleFor(p => p.Name).NotEmpty().MaximumLength(50);
			RuleFor(p => p.Description).NotEmpty();
		}
	}
}
