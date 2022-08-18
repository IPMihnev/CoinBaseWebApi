using Domain.Features.CoinBaseApi;
using MediatR;

namespace WebApiProject.Handlers.Currencies.GetAll
{
    public class GetAllCurrenciesHandler : IRequestHandler<GetAllCurrenciesRequest, GetAllCurrenciesResponse>
    {
        private readonly CoinBaseApiService coinBaseservice;

        public GetAllCurrenciesHandler(CoinBaseApiService coinBaseservice)
            => this.coinBaseservice = coinBaseservice;

        public async Task<GetAllCurrenciesResponse> Handle(
            GetAllCurrenciesRequest request,
            CancellationToken cancellationToken)
        {
            var currensies = await this.coinBaseservice.GetCurrenciesAsync();
            return new GetAllCurrenciesResponse(currensies.data);
        }
    }
}
