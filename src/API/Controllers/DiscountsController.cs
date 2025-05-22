using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers;

[ApiController]
[Route("api/discounts")]
public class DiscountsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Discounts: Get All");

    [HttpDelete("{id}")]
    public IActionResult Remove(int id) => Ok($"Discounts: Removed {id}");
}