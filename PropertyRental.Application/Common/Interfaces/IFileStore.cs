using Microsoft.AspNetCore.Http;
using PropertyRental.Application.Common.POCOs;
using System.Collections.Generic;

namespace PropertyRental.Application.Common.Interfaces
{
	public interface IFileStore
	{
		string SafeWriteFile(byte[] content, string sourceFileName, string path);
		ICollection<FileDirectoryPOCO> WriteFiles(ICollection<IFormFile> files, string path);
		FileDirectoryPOCO WriteFile(IFormFile file, string path);
		byte[] ReadFile(string path);
		string GetFileExtenstion(string file);
		byte[] GetFilesPackedIntoZip(ICollection<FileDirectoryPOCO> fileDirectories);
		string ReplaceInvalidChars(string fileName);
	}
}
