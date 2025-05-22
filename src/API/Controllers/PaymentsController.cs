using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers;

[ApiController]
[Route("api/payments")]
public class PaymentsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Payments: Get All");

    [HttpPost]
    public IActionResult Process() => Ok("Payments: Processed");
}