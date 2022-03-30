using XService.ApiCallServices.Abstractions;

namespace XService.ApiCallServices;

public class YService : IYService
{
    private readonly HttpClient _httpClient;
    public YService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> Get(bool isLong)
    {
        return await _httpClient.GetStringAsync($"Test?isLong={isLong.ToString().ToLower()}");
    }
}