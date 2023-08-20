namespace Proxy;

internal class MathServiceProxy
{
    private HttpClient? _httpClient;
    public MathServiceProxy(string url)
    {
        _httpClient = new HttpClient { BaseAddress = new Uri(url)};
    }
    public async Task<int> AddAsync(int a, int b)
    {
        var result = await _httpClient!.GetAsync($"add?a={a}&b={b}");
        if (result.IsSuccessStatusCode)
        {
            var sr = await result.Content.ReadAsStringAsync();
            return int.Parse(sr);
        }
        return 0;
    }
    public async Task<int> SubtractAsync(int a, int b)
    {
        var result = await _httpClient!.GetAsync($"subtract?a={a}&b={b}");
        if (result.IsSuccessStatusCode)
        {
            var sr = await result.Content.ReadAsStringAsync();
            return int.Parse(sr);
        }
        return 0;
    }
}
