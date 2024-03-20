using Microsoft.AspNetCore.Mvc;

namespace SampleAspNetCore02.Controllers;

[ApiController]
//[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    // GET
    
    
    // public IActionResult Index()
    // {
    //     return View();
    // }

    [Route("api/get-all")]
    [Route("get-all")]
    [Route("getall")]
    public string GetAll()
    {
        return "Hello from GetAll";
    }
    
    [Route("api/get-all-authors")]
    [Route("getall")]
    public string GetAllAuthors()
    {
        return "Hello from GetAllAuthors";
    }
    
    [Route("books/{id}")]
    public string GetById(int id)
    {
        return "Hello from Get by Id: " + id;
    }
    
    [Route("books/{id}/author/{authorId}")]
    public string GetAuthorAddressById(int id, int authorId)
    {
        return "Hello from Get by Id: " + id + " authorId: " + authorId;
    }
    
    [Route("search")]
    public string SearchBox(int id, int authorId, string name, int rating, int price)
    {
        return "Hello from searchBox: " + id ;
    }
}