namespace backend.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }

    // 导航属性
    public List<Post> Posts { get; set; }
}