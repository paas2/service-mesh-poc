namespace ZService.ApiCallServices.Abstractions;

public interface IXService
{
    Task<string> Get(bool isLong);
}