var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Get,
    RequestUri = new Uri("https://yh-finance.p.rapidapi.com/market/v2/get-quotes?region=US&symbols=AMD%2CIBM%2CAAPL"),
    Headers =
    {
        { "X-RapidAPI-Key", "ed8bbc525fmshe7f2ca46e69c3ffp179016jsne9ad147cd3e0" },
        { "X-RapidAPI-Host", "yh-finance.p.rapidapi.com" },
    },
};

using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    var body1 = response.Content.Headers;
    Console.WriteLine(body);
    Console.WriteLine(body1);
    File.WriteAllText(@"C:\Users\shasw\Desktop\cron.txt", body);
}