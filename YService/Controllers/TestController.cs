using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using YService.ApiCallServices.Abstractions;

namespace YService.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly IZService _zService;

    public TestController(IZService zService)
    {
        _zService = zService;
    }

    [HttpGet]
    public async Task<ActionResult> Get(bool isLong)
    {
        var result = new StringBuilder();
        
        if (isLong) 
            result.AppendLine($"{Assembly.GetExecutingAssembly().GetName().Name} GET Long called");
        else 
            result.AppendLine($"{Assembly.GetExecutingAssembly().GetName().Name} GET Short called");
        
        var zServiceResult = await _zService.Get(isLong);
        result.AppendLine(zServiceResult);

        return Ok(result.ToString());
    }
}