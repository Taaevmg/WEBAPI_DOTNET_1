using Microsoft.AspNetCore.Mvc;
using WEBAPI.Models.User;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
private static List<User> _user = new List<User>();
private static int _nextId = 1;

[HttpPost]
public IActionResult Create([FromBody] User user)
    {
        user.Id = _nextId++;
        _user.Add(user);
        return Created($"/user/{user.Id}", user);
    }

[HttpGet]
public IActionResult getlist()
    {
        return Ok(_user);
    }


[HttpGet("{id}")]
public IActionResult getById(int id)
{
        var user = _user.FirstOrDefault(u => u.Id == id);
        return user is not null ? Ok(user) : NotFound();  
}

}


