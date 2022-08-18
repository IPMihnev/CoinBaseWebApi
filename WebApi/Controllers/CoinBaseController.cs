using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApiProject.Handlers.Currencies.GetAll;
using WebApiProject.Handlers.Rates.GetAllByCurrency;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("/api/coinbase")]
    public class CoinBaseController : ControllerBase
    {
        private readonly IMediator mediator;

        public CoinBaseController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("currency")]
        [ProducesResponseType(typeof(GetAllCurrenciesResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult<GetAllCurrenciesResponse>> GetCurrencies()
            => this.Ok(await mediator.Send(new GetAllCurrenciesRequest()));

        [HttpGet("rates")]
        [ProducesResponseType(typeof(GeteAllRatesByCurrencyResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult<GeteAllRatesByCurrencyResponse>> GetRatesCurrencies(
            [FromQuery]string? fromCurrency)
                => this.Ok(await mediator.Send(new GeteAllRatesByCurrencyRequest(fromCurrency)));
    }
}
