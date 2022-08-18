using MediatR;

namespace WebApiProject.Handlers.Rates.GetAllByCurrency
{
    public class GeteAllRatesByCurrencyRequest : IRequest<GeteAllRatesByCurrencyResponse>
    {
        public GeteAllRatesByCurrencyRequest(string fromCurrency)
        {
            FromCurrency = fromCurrency;
        }

        public string FromCurrency { get; set; }
    }
}
