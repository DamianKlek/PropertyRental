using FluentValidation;

namespace PropertyRental.Application.Addresses.Commands.CreateAddress
{
	public class CreateAddressCommandValidator : AbstractValidator<CreateAddressCommand>
	{
		public CreateAddressCommandValidator()
		{
			RuleFor(a => a.StreetName).NotEmpty().MaximumLength(70);
			RuleFor(a => a.BuildingNumber).NotNull();
			RuleFor(a => a.CityName).NotEmpty().MaximumLength(70);
			RuleFor(a => a.ZipCode).NotEmpty().MaximumLength(20);
			RuleFor(a => a.CountryName).NotEmpty().MaximumLength(70);
			RuleFor(a => a.PropertyId).NotNull().GreaterThan(0);
		}
	}
}
