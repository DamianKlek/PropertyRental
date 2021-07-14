using PropertyRental.Application.Common.Interfaces;
using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace PropertyRental.Infrastructure.ExternalAPIs.NBPExchangeRate
{
	public partial class NBPClient : INBPClient
	{
		private string _baseUrl = "http://api.nbp.pl";
		private readonly HttpClient _httpClient;
		private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

		public NBPClient(IHttpClientFactory factory)
		{
			_httpClient = factory.CreateClient("NBPClient");
			_baseUrl = _httpClient.BaseAddress.ToString();
			_settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(() =>
			{
				var settings = new Newtonsoft.Json.JsonSerializerSettings();
				UpdateJsonSerializerSettings(settings);
				return settings;
			});
		}

		protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

		partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);

		public string BaseUrl
		{
			get { return _baseUrl; }
			set { _baseUrl = value; }
		}

		public async Task<string> GetExchangeRate(char tableName, string currencyCode, CancellationToken cancellationToken)
		{
			var urlBuilder = new StringBuilder();
			urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/exchangerates/rates/");
			urlBuilder.Append(tableName).Append('/');
			urlBuilder.Append(currencyCode).Append('/');
			var client = _httpClient;
			try
			{
				using (var request = new HttpRequestMessage())
				{
					request.Method = new HttpMethod("GET");
					var url = urlBuilder.ToString();
					request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
					var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);

					if (response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
						return responseData;
					}
					else
					{
						return "Something bad happened";
					}
				}
			}
			catch (Exception ex)
			{
				throw;
			}
		}
	}
}
