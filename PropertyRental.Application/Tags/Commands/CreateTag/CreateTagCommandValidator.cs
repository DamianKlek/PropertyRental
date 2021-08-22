using FluentValidation;

namespace PropertyRental.Application.Tags.Commands.CreateTag
{
	public class CreateTagCommandValidator : AbstractValidator<CreateTagCommand>
	{
		public CreateTagCommandValidator()
		{
			RuleFor(t => t.Name).NotEmpty().MaximumLength(20);
		}
	}
}
