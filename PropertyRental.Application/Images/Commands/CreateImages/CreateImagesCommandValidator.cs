using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental.Application.Images.Commands.CreateImages
{
	public class CreateImagesCommandValidator : AbstractValidator<CreateImagesCommand>
	{
		public CreateImagesCommandValidator()
		{
			RuleFor(i => i.PropertyImages).NotNull();
			RuleFor(i => i.PropertyImages).Must(collection => collection != null && collection.Count > 0);
			RuleForEach(i => i.ImagesDirectory).SetValidator(new CreateImagesVmValidator());
		}
	}
}
