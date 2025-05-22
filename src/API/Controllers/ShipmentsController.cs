using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers;

[ApiController]
[Route("api/shipments")]
public class ShipmentsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Shipments: Get All");

    [HttpGet("track/{id}")]
    public IActionResult Track(int id) => Ok($"Shipments: Track {id}");
}