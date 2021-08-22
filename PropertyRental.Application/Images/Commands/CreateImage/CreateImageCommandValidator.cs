using FluentValidation;

namespace PropertyRental.Application.Images.Commands.CreateImage
{
	public class CreateImageCommandValidator : AbstractValidator<CreateImageCommand>
	{
		public CreateImageCommandValidator()
		{
			RuleFor(i => i.Name).NotEmpty().MaximumLength(40);
			RuleFor(i => i.SourcePath).NotEmpty();
			RuleFor(i => i.PropertyId).NotNull().GreaterThan(0);
		}
	}
}
