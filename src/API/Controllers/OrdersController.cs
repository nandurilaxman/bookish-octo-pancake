using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Orders: Get All");

    [HttpPost]
    public IActionResult Create() => Ok("Orders: Created");
}