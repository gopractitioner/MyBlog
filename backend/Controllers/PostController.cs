// Controllers/PostsController.cs

using Blog.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostsController : ControllerBase
{
    private readonly IPostService _postService;

    public PostsController(IPostService postService)
    {
        _postService = postService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PostDto>>> GetPosts()
    {
        var posts = await _postService.GetAllPostsAsync();
        return Ok(posts);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PostDto>> GetPost(int id)
    {
        var post = await _postService.GetPostAsync(id);
        if (post == null)
            return NotFound();
        return Ok(post);
    }

    [HttpPost]
    public async Task<ActionResult<PostDto>> CreatePost(CreatePostDto dto)
    {
        var post = await _postService.CreatePostAsync(dto);
        return CreatedAtAction(nameof(GetPost), new { id = post.Id }, post);
    }

    // ... 其他API端点
    [HttpGet("test")]
    public IActionResult Test()
    {
        return Ok("API is working!");
    }
}