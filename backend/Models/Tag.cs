namespace backend.Models;

public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }

    // 导航属性
    public List<PostTag> PostTags { get; set; }
}