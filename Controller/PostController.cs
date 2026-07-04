using Microsoft.AspNetCore.Mvc;
using WEBAPI.Models.Post;

[ApiController]
[Route("[controller]")]
public class PostController : ControllerBase
{
private static List<Post> _post = new List<Post>();
private static int _nextId = 1;

[HttpPost]
public IActionResult Create([FromBody] Post Post)
    {
        Post.Id = _nextId++;
        _post.Add(Post);
        return Created($"/Post/{Post.Id}", Post);
    }

[HttpGet]
public IActionResult getlist()
    {
        return Ok(_post);
    }


[HttpGet("{id}")]
public IActionResult getById(int id)
{
        var Post = _post.FirstOrDefault(u => u.Id == id);
        return Post is not null ? Ok(Post) : NotFound();  
}
}