using FluentValidation;

namespace PropertyRental.Application.Tags.Commands.UpdateTag
{
	public class UpdateTagCommandValidator : AbstractValidator<UpdateTagCommand>
	{
		public UpdateTagCommandValidator()
		{
			RuleFor(t => t.Name).NotEmpty().MaximumLength(20);
		}
	}
}
