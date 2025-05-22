using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Products: Get All");

    [HttpDelete("{id}")]
    public IActionResult Delete(int id) => Ok($"Products: Deleted {id}");
}