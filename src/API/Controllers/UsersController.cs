using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Users: Get All");

    [HttpGet("{id}")]
    public IActionResult GetById(int id) => Ok($"Users: Get By ID {id}");
}