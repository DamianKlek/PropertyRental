using FluentValidation;

namespace PropertyRental.Application.Images.Commands.UpdateImage
{
	public class UpdateImageCommandValidator : AbstractValidator<UpdateImageCommand>
	{
		public UpdateImageCommandValidator()
		{
			RuleFor(i => i.Name).NotEmpty().MaximumLength(40);
			RuleFor(i => i.SourcePath).NotEmpty();
			RuleFor(i => i.PropertyId).NotNull().GreaterThan(0);
		}
	}
}
