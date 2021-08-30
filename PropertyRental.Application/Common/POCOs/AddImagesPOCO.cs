using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace PropertyRental.Application.Common.POCOs
{
	public class AddImagesPOCO
	{
		public ICollection<IFormFile> Files { get; set; }
		public int PropertyId { get; set; }
	}
}
