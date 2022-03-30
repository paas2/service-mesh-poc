using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using ZService.ApiCallServices.Abstractions;

namespace ZService.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly IXService _xService;

    public TestController(IXService xService)
    {
        _xService = xService;
    }

    [HttpGet]
    public async Task<ActionResult> Get(bool isLong)
    {
        // var result = new StringBuilder();
        //
        // if (isLong)
        // {
        //     result.AppendLine($"{Assembly.GetExecutingAssembly().GetName().Name} GET Long called");
        //     _xService.Get(false);
        // }
        // else 
        //     result.AppendLine($"{Assembly.GetExecutingAssembly().GetName().Name} GET Short called");
        //
        // return Ok(result.ToString());
        
        
        var result = new StringBuilder();
        
        if (isLong) 
            result.AppendLine($"{Assembly.GetExecutingAssembly().GetName().Name} GET Long called");
        else 
            result.AppendLine($"{Assembly.GetExecutingAssembly().GetName().Name} GET Short called");

        if (isLong)
        {
            var zServiceResult = await _xService.Get(false);
            result.AppendLine(zServiceResult);
        }

        return Ok(result.ToString());
    }
}