﻿using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("API is running!");
    }
}
