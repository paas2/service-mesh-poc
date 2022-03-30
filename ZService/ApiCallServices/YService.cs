using ZService.ApiCallServices.Abstractions;

namespace ZService.ApiCallServices;

public class XService : IXService
{
    private readonly HttpClient _httpClient;
    public XService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> Get(bool isLong)
    {
        return await _httpClient.GetStringAsync($"Test?isLong={isLong.ToString().ToLower()}");
    }
}