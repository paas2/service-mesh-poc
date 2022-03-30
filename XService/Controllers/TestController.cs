using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using XService.ApiCallServices.Abstractions;

namespace XService.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly IYService _yService;

    public TestController(IYService yService)
    {
        _yService = yService;
    }

    [HttpGet]
    public async Task<ActionResult> Get(bool isLong)
    {
        var result = new StringBuilder();

        if (isLong) 
            result.AppendLine($"{Assembly.GetExecutingAssembly().GetName().Name} GET Long called");
        else 
            result.AppendLine($"{Assembly.GetExecutingAssembly().GetName().Name} GET Short called");
        
        var yServiceResult = await _yService.Get(isLong);
        result.AppendLine(yServiceResult);

        return Ok(result.ToString());
    }
}