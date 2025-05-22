using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers;

[ApiController]
[Route("api/profiles")]
public class ProfilesController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Profiles: Get All");

    [HttpPut("{id}")]
    public IActionResult Update(int id) => Ok($"Profiles: Updated {id}");
}