using Microsoft.AspNetCore.Mvc;
using WEBAPI.Models.Like;

[ApiController]
[Route("[controller]")]
public class LikeController : ControllerBase
{
private static List<Like> _like = new List<Like>();
private static int _nextId = 1;

[HttpPost]
public IActionResult Create([FromBody] Like Like)
    {
        Like.Id = _nextId++;
        _like.Add(Like);
        return Created($"/Like/{Like.Id}", Like);
    }

[HttpGet]
public IActionResult getlist()
    {
        return Ok(_like);
    }


[HttpGet("{id}")]
public IActionResult getById(int id)
{
        var Like = _like.FirstOrDefault(u => u.Id == id);
        return Like is not null ? Ok(Like) : NotFound();  
}
}