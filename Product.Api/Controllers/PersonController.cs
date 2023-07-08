using Microsoft.AspNetCore.Mvc;

namespace Product.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    // GET
    [HttpGet]
    public string Index()
    {
        return "hola desde person controller";
    }
}