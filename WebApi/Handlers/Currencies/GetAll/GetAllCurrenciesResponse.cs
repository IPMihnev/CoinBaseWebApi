using Domain.Features.CoinBaseApi.Models;

namespace WebApiProject.Handlers.Currencies.GetAll
{
    public class GetAllCurrenciesResponse
    {
        public GetAllCurrenciesResponse(IEnumerable<Currency> currencies)
        {
            this.Currencies = currencies != null ? currencies.ToArray() : Array.Empty<Currency>();
        }

        public Currency[] Currencies { get; set; }
    }
}
