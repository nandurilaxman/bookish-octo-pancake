using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers;

[ApiController]
[Route("api/categories")]
public class CategoriesController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Categories: Get All");

    [HttpPost]
    public IActionResult Add() => Ok("Categories: Added");
}