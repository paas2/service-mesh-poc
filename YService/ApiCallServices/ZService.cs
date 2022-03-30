using YService.ApiCallServices.Abstractions;

namespace YService.ApiCallServices;

public class ZService : IZService
{
    private readonly HttpClient _httpClient;
    public ZService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> Get(bool isLong)
    {
        return await _httpClient.GetStringAsync($"Test?isLong={isLong.ToString().ToLower()}");
    }
}