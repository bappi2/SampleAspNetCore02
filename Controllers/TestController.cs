using Microsoft.AspNetCore.Mvc;

namespace SampleAspNetCore02.Controllers;
[ApiController]
[Route("test/[action]")]
public class TestController : ControllerBase
{
    public string Get()
    {
        return "Hello from Get"; 
    }
    
    public string Get1()
    {
        return "Hello from Get1"; 
    }
}