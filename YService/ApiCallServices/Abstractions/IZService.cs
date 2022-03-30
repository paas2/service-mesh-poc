namespace YService.ApiCallServices.Abstractions;

public interface IZService
{
    Task<string> Get(bool isLong);
}