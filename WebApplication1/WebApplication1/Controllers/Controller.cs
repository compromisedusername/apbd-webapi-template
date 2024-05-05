using Microsoft.AspNetCore.DataProtection.Internal;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class Controller : ControllerBase
{

    [HttpGet]
    async public Task<IActionResult> GetItems()
    {
        return Ok();
    }
}