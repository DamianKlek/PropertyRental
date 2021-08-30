using Microsoft.AspNetCore.Http;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Infrastructure.FileStore.Exceptions;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PropertyRental.Infrastructure.FileStore
{
	public class FileWrapper : IFileWrapper
	{
		public byte[] ReadFileAsync(string path)
		{
			var bytes = File.ReadAllBytes(path);
			return bytes;
		}

		public void WriteAllBytes(string outputFile, byte[] content)
		{
			File.WriteAllBytes(outputFile, content);
		}

		public async Task<string> WriteFileAsync(IFormFile file, string outputFile)
		{
			try
			{
				using (FileStream fileStream = File.Create(outputFile))
				{
					await file.CopyToAsync(fileStream);
					fileStream.Flush();
				}
				return $"Uploaded successfully {outputFile}";
			}
			catch (Exception ex)
			{
				throw new SaveFileIssueException($"There was an issues with saving file {outputFile}", ex);
			}
		}
	}
}
