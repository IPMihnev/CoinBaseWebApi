using Domain.Features.CoinBaseApi.Models;

namespace WebApiProject.Handlers.Rates.GetAllByCurrency
{
    public class GeteAllRatesByCurrencyResponse
    {
        public GeteAllRatesByCurrencyResponse(RatesData rates)
        {
            this.Rates = rates;
        }
        public RatesData Rates { get; set; }
    }
}
