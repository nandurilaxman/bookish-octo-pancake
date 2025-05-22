using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers;

[ApiController]
[Route("api/reviews")]
public class ReviewsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Reviews: Get All");

    [HttpPut("{id}")]
    public IActionResult Update(int id) => Ok($"Reviews: Updated {id}");
}