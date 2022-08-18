using Domain.Features.CoinBaseApi;
using MediatR;

namespace WebApiProject.Handlers.Rates.GetAllByCurrency
{
    public class GeteAllRatesByCurrencyHandler : IRequestHandler<GeteAllRatesByCurrencyRequest, GeteAllRatesByCurrencyResponse>
    {
        private readonly CoinBaseApiService coinBaseservice;

        public GeteAllRatesByCurrencyHandler(CoinBaseApiService coinBaseservice)
            => this.coinBaseservice = coinBaseservice;
        public async Task<GeteAllRatesByCurrencyResponse> Handle(
            GeteAllRatesByCurrencyRequest request,
            CancellationToken cancellationToken)
        {
            var result = await this.coinBaseservice.GetRatesAsync(request.FromCurrency);
            return new GeteAllRatesByCurrencyResponse(result);
        }
    }
}
