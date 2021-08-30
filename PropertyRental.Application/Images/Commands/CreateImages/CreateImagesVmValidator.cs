using FluentValidation;

namespace PropertyRental.Application.Images.Commands.CreateImages
{
	public class CreateImagesVmValidator : AbstractValidator<CreateImagesVm>
	{
		public CreateImagesVmValidator()
		{
			RuleFor(i => i.Name).NotEmpty();
			RuleFor(i => i.SourcePath).NotEmpty();
			RuleFor(i => i.PropertyId).NotNull().GreaterThan(0);
		}
	}
}