using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Interfaces
{
	public interface INBPClient
	{
		Task<string> GetExchangeRate(char tableName, string searchFilter, CancellationToken cancellationToken);
	}
}
