namespace backend.Models;

public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    // 外键
    public int PostId { get; set; }
    public int AuthorId { get; set; }
    public int? ParentId { get; set; }  // 用于回复功能

    // 导航属性
    public Post Post { get; set; }
    public User Author { get; set; }
    public Comment Parent { get; set; }
    public List<Comment> Replies { get; set; }
}