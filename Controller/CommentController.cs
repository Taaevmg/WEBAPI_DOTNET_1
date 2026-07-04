using Microsoft.AspNetCore.Mvc;
using WEBAPI.Models.Comment;

[ApiController]
[Route("[controller]")]
public class CommentController : ControllerBase
{
private static List<Comment> _comment = new List<Comment>();
private static int _nextId = 1;

[HttpPost]
public IActionResult Create([FromBody] Comment Comment)
    {
        Comment.Id = _nextId++;
        _comment.Add(Comment);
        return Created($"/Comment/{Comment.Id}", Comment);
    }

[HttpGet]
public IActionResult getlist()
    {
        return Ok(_comment);
    }


[HttpGet("{id}")]
public IActionResult getById(int id)
{
        var Comment = _comment.FirstOrDefault(u => u.Id == id);
        return Comment is not null ? Ok(Comment) : NotFound();  
}
}