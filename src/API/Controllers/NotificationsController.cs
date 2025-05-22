using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers;

[ApiController]
[Route("api/notifications")]
public class NotificationsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Notifications: Get All");

    [HttpPost]
    public IActionResult Send() => Ok("Notifications: Sent");
}