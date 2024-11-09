using NpgsqlTypes;

namespace backend.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string? Summary { get; set; }
    public bool IsPublished { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int ViewCount { get; set; }

    // 外键
    public int AuthorId { get; set; }
    public int CategoryId { get; set; }

    // 导航属性
    public User Author { get; set; }
    public Category Category { get; set; }
    public List<Comment> Comments { get; set; }
    public List<PostTag> PostTags { get; set; }

    // 全文搜索向量
    public NpgsqlTsVector SearchVector { get; set; }
}