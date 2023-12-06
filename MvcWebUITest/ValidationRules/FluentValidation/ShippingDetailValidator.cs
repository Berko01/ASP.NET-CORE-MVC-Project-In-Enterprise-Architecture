using FluentValidation;
using MvcWebUITest.Models;

namespace MvcWebUITest.ValidationRules.FluentValidation
{
	public class ShippingDetailValidator:AbstractValidator<ShippingDetail>
	{
		public ShippingDetailValidator()
		{
			RuleFor(s => s.FirstName).NotEmpty().WithMessage("Adı gereklidir.");
			RuleFor(s => s.FirstName).MinimumLength(2);
			RuleFor(s => s.LastName).NotEmpty();
			RuleFor(s => s.Address).NotEmpty();

			//RuleFor(s => s.City).NotEmpty().When(s => s.Age < 18);

			//RuleFor(s => s.FirstName).Must(StartWithA);
		}

		private bool StartWithA(String arg)
		{
			return arg.StartsWith("A");
		}
	}
}
