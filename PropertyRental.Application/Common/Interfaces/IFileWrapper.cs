using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Interfaces
{
	public interface IFileWrapper
	{
		void WriteAllBytes(string outputFile, byte[] content);
		Task<string> WriteFileAsync(IFormFile file, string outputFile);
		byte[] ReadFileAsync(string path);
	}
}
