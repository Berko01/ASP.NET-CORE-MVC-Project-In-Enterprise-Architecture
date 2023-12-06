using System.ComponentModel.DataAnnotations;

namespace MvcWebUITest.Models
{
	//Bu model single Responsibility'e uymaz. Validationla model aynı yerde.
	public class ShippingDetail
	{
		//[Microsoft.Build.Framework.Required]
		public String FirstName { get; set; }
		//[Microsoft.Build.Framework.Required]
		public String LastName { get; set; }
		//[Microsoft.Build.Framework.Required]
		[DataType(DataType.EmailAddress)]
		public String Email { get; set; }
		//[Microsoft.Build.Framework.Required]
		public String City { get; set; }
		//[Microsoft.Build.Framework.Required]
		//[MinLength(10,ErrorMessage = "Minumum 10 karakter olmalı.")]
		public String Address { get; set; }
		//[Microsoft.Build.Framework.Required]
		public int Age { get; set; }

	}
}
