namespace XService.ApiCallServices.Abstractions;

public interface IYService
{
    Task<string> Get(bool isLong);
}