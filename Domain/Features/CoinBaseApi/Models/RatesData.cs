namespace Domain.Features.CoinBaseApi.Models
{
    public class RatesData
    {
        public string Currency { get; set; }
        public Dictionary<string, string> Rates { get; set; }
    }
}
