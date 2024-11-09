// Services/IPostService.cs
namespace Blog.Services;

public interface IPostService
{
    Task<PostDto?> GetPostAsync(int id);
    Task<IEnumerable<PostDto>> GetAllPostsAsync();
    Task<PostDto> CreatePostAsync(CreatePostDto dto);
    Task UpdatePostAsync(int id, UpdatePostDto dto);
    Task DeletePostAsync(int id);
}
