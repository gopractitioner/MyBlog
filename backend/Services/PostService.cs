using AutoMapper;
using backend.Data.Repositories;
using backend.Models;
namespace Blog.Services;


public class PostService : IPostService
{
    private readonly IBaseRepository<Post> _postRepository;
    private readonly IMapper _mapper;

    public PostService(IBaseRepository<Post> postRepository, IMapper mapper)
    {
        _postRepository = postRepository;
        _mapper = mapper;
    }

    public async Task<PostDto?> GetPostAsync(int id)
    {
        var post = await _postRepository.GetByIdAsync(id);
        return post == null ? null : _mapper.Map<PostDto>(post);
    }

    public async Task<IEnumerable<PostDto>> GetAllPostsAsync()
    {
        var posts = await _postRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<PostDto>>(posts);
    }

    public async Task<PostDto> CreatePostAsync(CreatePostDto dto)
    {
        var post = _mapper.Map<Post>(dto);
        await _postRepository.AddAsync(post);
        return _mapper.Map<PostDto>(post);
    }

    public async Task UpdatePostAsync(int id, UpdatePostDto dto)
    {
        var post = await _postRepository.GetByIdAsync(id);
        if (post == null)
            throw new KeyNotFoundException($"Post with ID {id} not found");

        _mapper.Map(dto, post);
        await _postRepository.UpdateAsync(post);
    }

    public async Task DeletePostAsync(int id)
    {
        var post = await _postRepository.GetByIdAsync(id);
        if (post == null)
            throw new KeyNotFoundException($"Post with ID {id} not found");

        await _postRepository.DeleteAsync(post);
    }
}