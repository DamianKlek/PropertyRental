using Microsoft.AspNetCore.Http;

namespace PropertyRental.Application.Common.POCOs
{
	public class AddImagePOCO
	{
		public IFormFile File { get; set; }
		public int PropertyId { get; set; }
	}
}
