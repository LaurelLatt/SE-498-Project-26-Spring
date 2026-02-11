using Microsoft.AspNetCore.Mvc;

namespace Project498.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StringsController : ControllerBase
{
    [HttpGet("reverse/{input}")]
    public IActionResult Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return Ok(string.Empty);
        }

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return Ok(new string(charArray));
    }
}
