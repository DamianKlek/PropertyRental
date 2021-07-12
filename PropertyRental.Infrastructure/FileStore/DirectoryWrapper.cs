using PropertyRental.Application.Common.Interfaces;
using System.IO;

namespace PropertyRental.Infrastructure.FileStore
{
	public class DirectoryWrapper : IDirectoryWrapper
	{
		public void CreateDirectory(string path)
		{
			Directory.CreateDirectory(path);
		}
	}
}
