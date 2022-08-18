namespace Domain.Features.CoinBaseApi.Models
{
    public class Currency
    {
        public string id { get; set; }
        public string name { get; set; }
        public string min_size { get; set; }
    }

    public class CurrencyData
    {
        public List<Currency> data { get; set; }
    }
}
