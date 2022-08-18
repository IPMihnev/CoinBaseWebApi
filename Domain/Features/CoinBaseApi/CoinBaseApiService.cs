using Domain.Features.CoinBaseApi.Models;
using Newtonsoft.Json;

namespace Domain.Features.CoinBaseApi
{
    public class CoinBaseApiService
    {
        private readonly HttpClient httpClient;

        public CoinBaseApiService(HttpClient httpClient)
            => this.httpClient = httpClient;

        public async Task<CurrencyData> GetCurrenciesAsync()
        {
            var res = await this.httpClient.GetFromJsonAsync<CurrencyData>("currencies");
            return res;
        }

        public async Task<RatesData> GetRatesAsync(string fromCurrency)
        {
            string url;
            if (fromCurrency != null)
            {
                url = $"exchange-rates?currency={fromCurrency}";
            }
            else
            {
                url = "exchange-rates";
            }
            var response = await this.httpClient.GetAsync(url);
            var responceBody = await response.Content.ReadAsStringAsync();
            var def = new
            {
                data = new
                {
                    currency = string.Empty,
                    rates = new Dictionary<string, string>()
                }
            };
            var result = JsonConvert.DeserializeAnonymousType(responceBody, def);
            return new RatesData
            {
                Currency = result.data.currency,
                Rates = result.data.rates
            };
        }
    }
}
