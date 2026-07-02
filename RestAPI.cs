using System.Net.Http.Json;

namespace ValueConverter
{
    internal class RestAPI
    {
        HttpClient client = new HttpClient();

        public async Task<Dictionary<string, string>> GetCurrencies()
        {
            string url = "https://api.frankfurter.app/currencies";
            Dictionary<string, string> result = await client.GetFromJsonAsync<Dictionary<string, string>>(url);
            return result;
        }

        public async Task<decimal> GetRate(string from, string to)
        {
            string url = "https://api.frankfurter.app/latest?from=" + from + "&to=" + to;
            RateResponse result = await client.GetFromJsonAsync<RateResponse>(url);
            return result.rates[to];
        }
    }

    class RateResponse
    {
        public Dictionary<string, decimal> rates { get; set; }
    }
}
